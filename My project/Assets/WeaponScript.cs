using System;
using Unity.VisualScripting;
using UnityEngine;
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
        //scriptAttack = b.GetComponent<AttackScript>();
        var Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Enemy.GetComponent<EnemyScript>();
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
        if (trigger.gameObject.name.Contains("Enemy"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            Debug.Log(script.EnemyHp);
            script.EnemyHp -= BaseDamage;
        }
    }

}
