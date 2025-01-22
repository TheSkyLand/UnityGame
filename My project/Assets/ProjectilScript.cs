using UnityEngine;

public class ProjectilScript : MonoBehaviour
{
    public float speed = 2.0f;
    public EnemyScript script;
    public RangedAttack Ranged;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var Enemy = GameObject.FindGameObjectWithTag("Enemy");
        GetComponent<EnemyScript>();
        GetComponent<RangedAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider trigger)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (trigger.gameObject.name.Contains("Enemy"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            Debug.Log(script.EnemyHp);
            script.EnemyHp -= Ranged.BaseDamage;
        }
    }
}
