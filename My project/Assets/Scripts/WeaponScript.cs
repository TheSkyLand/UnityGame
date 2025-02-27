
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    public float AttackSpeed = 1.0f;
    public EnemyScript script;
    private Animator anim;


    //
    public bool IsRanged;
    public int maxAmmo = 100; // количество дополнительных патронов
    public int maxAmmoInClip = 10; // емкость магазина
    public int gunAmmo = 0; // количество патронов в магазине
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
        // вводим временную переменную (она служит для красоты перезарядки)
        var ammo = 0;
        // если у нас были патроны в магазине то нашей временной переменной присваиваем значение оставшихся патронов
        if (gunAmmo > 0) { ammo = gunAmmo; gunAmmo = 0; }
        // (условие №2)если дополнительных патронов меньше чем максимальная емкость магазина...
        if (maxAmmoInClip > maxAmmo)
        {
            // (условие №3) если количество дополнительных патронов + оставшихся в магазине больше максимальной емкости магазина...
            if (maxAmmo + ammo > maxAmmoInClip)
            {
                // то кладем в магазин патроны в каличестве максимального его объема
                gunAmmo = maxAmmoInClip;
                // а дополнительные патроны считаем по формуле: дополнительные патроны = дополнительные патроны + оставшиеся патроны - объем магазина
                maxAmmo = maxAmmo + ammo - maxAmmoInClip;
            }
            else
            {// если условие №3 не выполняется...
             // то кладем в магазин патроны в количетсве равное дополнительные патроны + те что остались
                gunAmmo = maxAmmo + ammo;
                // а дополнительные патроны приравниваем нулю
                maxAmmo = 0;
            }
        }
        else
        {// если условие №2 не выполняется...
         // то кладем в магазин патроны в каличестве максимального его объема
            gunAmmo = maxAmmoInClip;
            // а дополнительные патроны считаем по формуле: дополнительные патроны = дополнительные патроны - объем магазина + оставшиеся
            maxAmmo = maxAmmo - maxAmmoInClip + ammo;
        }
        // включаем триггер (стрелять можно)
        canShoot = true;
        yield return new WaitForSeconds(1f);
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
        gunAmmo--;
        GameObject buf = Instantiate(Projectile);
        Destroy(buf, 2);
        // передаём заспавненный компонент в скрипт Bullet в функцию setDrection - определение направления полёта пули
        buf.GetComponent<ProjectileScript>().setDirection(transform.forward);
        buf.transform.position = ProjectileStart.transform.position;
        // Задаём начальное положение пули на карте - начало в новом пустом объекте unity rifleStart, его положение
        // ! Важно определить объекты в unity, иначе будет ошибка
        buf.transform.rotation = ProjectileStart.transform.rotation;
        // Положение (Угол) пули относительно положения угла наклона оружия
        //buf.transform.rotation = transform.rotation;
        Debug.Log("Ranged Attack");
        yield return new WaitForSeconds(0.1f);
        // разрешаем стрелять
        canShoot = true;
        // выходим с сопрограммы
        yield break;
    }
}
