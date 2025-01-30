using System.Collections;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public float BaseDamage = 1;
    public float AttackSpeed = 1;
    public EnemyScript script;
    [SerializeField] GameObject Projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<EnemyScript>();
        GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           Destroy(Instantiate(Projectile, transform.position, transform.rotation), 1);
        }
    }
}
