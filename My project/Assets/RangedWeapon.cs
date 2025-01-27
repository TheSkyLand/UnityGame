using System.Collections;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public float BaseDamage = 1;
    public float ProjectileSpeed = 1;
    public float AttackSpeed = 1;
    public EnemyScript script;
    public Rigidbody Projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody p = Instantiate(Projectile, transform.position, transform.rotation);
            p.linearVelocity = transform.forward * ProjectileSpeed;
            Destroy(p.gameObject, 1);
        }

    }
    void OnTriggerEnter(Collider trigger)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (trigger.gameObject.CompareTag("Enemy"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            Debug.Log(script.EnemyHp);
            script.EnemyHp -= BaseDamage;
        }
    }
}
