using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public EnemyScript Enemy;
    public GameObject Projectile;
    public float ProjectileSpeed = 10;
    Vector3 ProjectileDirection; // Направление снаряда
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
    void OnTriggerEnter(Collider trigger)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (trigger.tag == "Enemy")
        {
            // If the GameObject has the same tag as specified, output this message in the console  
               Destroy(trigger.gameObject);
               Destroy(trigger.GetComponent<EnemyScript>());
               Debug.Log("Do something else here");
        }        
    }
}
