
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    public float AttackSpeed = 1.0f;
    public EnemyScript script;
    private Animator anim;
    // �������� ����� ����������
    protected float cooldown = 0;
    // ����� �������� (��������)
    private float timer = 0;
    public bool IsRanged;
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject ProjectileStart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cooldown = timer;

        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {   
        timer += Time.deltaTime;
    }
    void OnTriggerEnter(Collider Enemy)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (Enemy.tag == "Enemy")
        {
            // If the GameObject has the same tag as specified, output this message in the console  
            Enemy.GetComponent<EnemyScript>().ChangeHpBux(+BaseDamage);
        }
    }

    public void Attack()
    {
        if (IsRanged == false)
        {
            if (timer > cooldown)
            {
                StartCoroutine(Attackf());
                Debug.Log("Melee Attack");
                timer = 0;
            }
        }
        else
        {
            if (timer > cooldown)
            {
                StartCoroutine(Shoot());
                timer = 0;
            }
        }
    }
    private IEnumerator Attackf()
    {
        anim.speed = AttackSpeed;
        anim.Play("KatanaAttack");
        yield return null;
        Debug.Log("worked");
    }
    public IEnumerator Shoot()
    {
        GameObject buf = Instantiate(Projectile);
        Destroy(buf, 2);

        // ������� ������������ ��������� � ������ Bullet � ������� setDrection - ����������� ����������� ����� ����
        buf.GetComponent<ProjectileScript>().setDirection(transform.forward);
        buf.transform.position = ProjectileStart.transform.position;
        // ����� ��������� ��������� ���� �� ����� - ������ � ����� ������ ������� unity rifleStart, ��� ���������
        // ! ����� ���������� ������� � unity, ����� ����� ������
        buf.transform.rotation = ProjectileStart.transform.rotation;
        // ��������� (����) ���� ������������ ��������� ���� ������� ������
        //buf.transform.rotation = transform.rotation;
        Debug.Log("Ranged Attack");
        yield return null;
    }
}
