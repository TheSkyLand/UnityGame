using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public float BaseDamage = 1;
    public float AttackSpeed = 1;
    public EnemyScript script;
    [SerializeField] GameObject Projectile;
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
        timer += Time.deltaTime;
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0) || auto)
        {
            // Если время выстрела превышает интервал
            if (timer > cooldown)
            {
                OnShoot();
                timer = 0;
            }
        }
    }
}
