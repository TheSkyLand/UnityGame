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
    protected bool auto = false;
    // Интервал между выстрелами
    protected float cooldown = 0;
    // Время выстрела (закрытая)
    private float timer = 0;
    protected virtual void OnShoot() { }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<EnemyScript>();
        GetComponent<Rigidbody>();
        cooldown = timer;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Shoot()
    {
        GameObject projectile = Instantiate(Projectile);
        Destroy(projectile, 1);
        projectile.GetComponent<ProjectileScript>().setDirection(transform.forward);
        // Если время выстрела превышает интервал

        // Задаём начальное положение пули на карте - начало в новом пустом объекте unity rifleStart, его положение
        // ! Важно определить объекты в unity, иначе будет ошибыка
        projectile.transform.position = ProjectileStart.transform.position;
        // Положение (Угол) пули относительно положения угла наклона оружия
        projectile.transform.rotation = transform.rotation;

        if (timer > cooldown)
        {
            OnShoot();
            timer = 1;
        }
    }
}
