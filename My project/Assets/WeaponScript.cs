using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    
    // public GameObject b;
    public EnemyScript script;
    //public AttackScript scriptAttack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scriptAttack = b.GetComponent<AttackScript>();
        var Enemy = GameObject.FindGameObjectWithTag("Enemy");
        var script = Enemy.GetComponent<EnemyScript>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            Debug.Log(script.EnemyHp);
            script.EnemyHp -= BaseDamage;
        }
    }
}
