
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class WeaponScript : MonoBehaviour
{
    public float BaseDamage;
    public float AttackSpeed;
    public EnemyScript script;
    private Animator anim;
    public Text Text;
    public bool HasAmmo = false;




    //
    public bool IsRanged;
    public int maxAmmo = 100; // ���������� �������������� ��������
    public int maxAmmoInClip = 10; // ������� ��������
    public int gunAmmo = 10; // ���������� �������� � ��������
    public bool canShoot = true;


    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject ProjectileStart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gunAmmo = maxAmmoInClip;
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (HasAmmo || IsRanged)
        {
            Text.text = "AMMO: " + gunAmmo.ToString() + "/" + maxAmmoInClip.ToString();
        } 
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
            if (Input.GetMouseButtonDown(0) & canShoot)
            {

                StartCoroutine(Shoot());

            }
            if (Input.GetKeyDown(KeyCode.R) & canShoot && gunAmmo != maxAmmo && gunAmmo != maxAmmoInClip)
            {
                canShoot = false;
                StartCoroutine(CoroutineReload());
            }

        }
    }
    public IEnumerator CoroutineReload()
    {
        // ������ ��������� ���������� (��� ������ ��� ������� �����������)
        var ammo = 0;
        // ���� � ��� ���� ������� � �������� �� ����� ��������� ���������� ����������� �������� ���������� ��������
        if (gunAmmo > 0) { ammo = gunAmmo; gunAmmo = 0; }
        // (������� �2)���� �������������� �������� ������ ��� ������������ ������� ��������...
        if (maxAmmoInClip > maxAmmo)
        {
            // (������� �3) ���� ���������� �������������� �������� + ���������� � �������� ������ ������������ ������� ��������...
            if (maxAmmo + ammo > maxAmmoInClip)
            {
                // �� ������ � ������� ������� � ���������� ������������� ��� ������
                gunAmmo = maxAmmoInClip;
                // � �������������� ������� ������� �� �������: �������������� ������� = �������������� ������� + ���������� ������� - ����� ��������
                maxAmmo = maxAmmo + ammo - maxAmmoInClip;
            }
            else
            {// ���� ������� �3 �� �����������...
             // �� ������ � ������� ������� � ���������� ������ �������������� ������� + �� ��� ��������
                gunAmmo = maxAmmo + ammo;
                // � �������������� ������� ������������ ����
                maxAmmo = 0;
            }
        }
        else
        {// ���� ������� �2 �� �����������...
         // �� ������ � ������� ������� � ���������� ������������� ��� ������
            gunAmmo = maxAmmoInClip;
            // � �������������� ������� ������� �� �������: �������������� ������� = �������������� ������� - ����� �������� + ����������
            maxAmmo = maxAmmo - maxAmmoInClip + ammo;
        }
        // �������� ������� (�������� �����)
        canShoot = true;
        yield return new WaitForSeconds(1f);
    }
    private IEnumerator Attackf()
    {
        // yield return new WaitForSeconds(2.5f + -AttackSpeed);
        anim.speed = 2.5f + -AttackSpeed;
        anim.Play("KatanaAttack");
        yield return null;
    }
    public IEnumerator Shoot()
    {
        if (gunAmmo > 0)
        {
            gunAmmo--;
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
            yield return new WaitForSeconds(0.1f);
            // ��������� ��������
            canShoot = true;
            // ������� � �����������
            yield break;
        }

    }
}
