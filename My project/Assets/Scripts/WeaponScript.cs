 using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.GraphicsBuffer;

public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    public float AttackSpeed = 1.0f;
    public EnemyScript script;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.Play("Idle");
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
        StartCoroutine(Attackf());
        Debug.Log("worked");
    }
    private IEnumerator Attackf()
    {
        anim.Play("KatanaAttack");
        yield return new WaitForSeconds(AttackSpeed * Time.deltaTime);
        Debug.Log("worked");
    }
}
