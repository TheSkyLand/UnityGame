using Unity.VisualScripting;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public GameObject Projectile;
    public float ProjectileSpeed = 20;
    public WeaponScript Weapon;
    public EnemyScript Enemy;
    Vector3 ProjectileDirection; // ����������� �������
    public void setDirection(Vector3 dir)
    {
        ProjectileDirection = dir;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += ProjectileDirection * ProjectileSpeed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider Enemy)
    {   
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (Enemy.tag == "Enemy")
        {
            // If the GameObject has the same tag as specified, output this message in the console  
            Enemy.GetComponent<EnemyScript>().ChangeHpBux(2);
            Destroy(Projectile);
        }
    }
}
