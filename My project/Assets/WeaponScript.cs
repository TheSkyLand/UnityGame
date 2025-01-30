using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.GraphicsBuffer;

public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    public GameObject Object;
    public float AttackSpeed = 1000.0f;
    // public GameObject b;
    public EnemyScript script;
    //public AttackScript scriptAttack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // transform.localRotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Mathf.Clamp(transform.rotation.z, -15, 15));
            // transform.rotation = Quaternion.Euler(new Vector3(Mathf.Sin(Time.time * AttackSpeed) * AttackSpeed, 0, 1));
            // transform.Rotate(Vector3.up, AttackSpeed * Time.deltaTime);
            Debug.Log("Attack initialized");
        }
        else if (Input.GetMouseButtonUp(0))
        {
        }
    }
    void OnTriggerEnter(Collider trigger)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (trigger.tag == "Enemy")
        {

  
                Destroy(trigger.gameObject);
                Destroy(trigger.GetComponent<EnemyScript>());
                Debug.Log("Do something else here");
            
        }
    }

}
