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
    // Интервал между выстрелами
    protected float cooldown = 0;
    // Время выстрела (закрытая)
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
            // Если время выстрела превышает интервал

            // Задаём начальное положение пули на карте - начало в новом пустом объекте unity rifleStart, его положение
            // ! Важно определить объекты в unity, иначе будет ошибыка
            projectile.transform.position = ProjectileStart.transform.position;
            // Положение (Угол) пули относительно положения угла наклона оружия
            projectile.transform.rotation = transform.rotation;
        }

    }
}
