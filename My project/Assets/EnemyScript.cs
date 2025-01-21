using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float EnemyLevel = 0;
    public float EnemyHp = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float EnemyHpCalc = EnemyHp = (EnemyLevel * 2.5F);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHp <= 0)
        {
            Debug.Log("The Enemy Has died");
            Destroy(gameObject);
            
            if (gameObject.IsDestroyed() == true)
            {


                Debug.Log("uhhhh tii");
            }

        }
    }
}
