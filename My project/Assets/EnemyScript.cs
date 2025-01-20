using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float EnemyLevel = 0;
    public float EnemyHp = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHp == 0)
        {
            Destroy(gameObject);
        }
        
    }
}
