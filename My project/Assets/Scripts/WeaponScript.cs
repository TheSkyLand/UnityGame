
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
            StartCoroutine(Attackf());
            Debug.Log("Melee Attack");
        }
        else 
        {
            StartCoroutine(Shoot());
        }
    }
    private IEnumerator Attackf()
    {
        anim.Play("KatanaAttack");
        yield return new WaitForSeconds(AttackSpeed * Time.deltaTime);
        Debug.Log("worked");
    }
    public IEnumerator Shoot()
    {
        GameObject buf = Instantiate(Projectile);

        // ������� ������������ ��������� � ������ Bullet � ������� setDrection - ����������� ����������� ����� ����
        buf.GetComponent<ProjectileScript>().setDirection(transform.forward);

        // ����� ��������� ��������� ���� �� ����� - ������ � ����� ������ ������� unity rifleStart, ��� ���������
        // ! ����� ���������� ������� � unity, ����� ����� ������
        buf.transform.position = ProjectileStart.transform.position;
        // ��������� (����) ���� ������������ ��������� ���� ������� ������
        buf.transform.rotation = transform.rotation;
        Debug.Log("Ranged Attack");
        yield return new WaitForSeconds(AttackSpeed * Time.deltaTime);
    }
}
