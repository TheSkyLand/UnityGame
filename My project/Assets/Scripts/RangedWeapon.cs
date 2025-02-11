 using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public float BaseDamage = 1;
    public float AttackSpeed = 1;
    public EnemyScript script;
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject ProjectileStart;
    // �������� ����� ����������
    protected float cooldown = 0;
    // ����� �������� (��������)
    private float timer = 0;

    public bool hasWeapon = false;
    protected virtual void OnShoot() { }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cooldown = timer;
        GetComponent<EnemyScript>();
        GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0) && hasWeapon)
        {
            GameObject projectile = Instantiate(Projectile);
            Destroy(projectile, 2);
            projectile.GetComponent<ProjectileScript>().setDirection(transform.forward);
            // ���� ����� �������� ��������� ��������

            // ����� ��������� ��������� ���� �� ����� - ������ � ����� ������ ������� unity rifleStart, ��� ���������
            // ! ����� ���������� ������� � unity, ����� ����� �������
            projectile.transform.position = ProjectileStart.transform.position;
            // ��������� (����) ���� ������������ ��������� ���� ������� ������
            projectile.transform.rotation = transform.rotation;
        }

    }
}
