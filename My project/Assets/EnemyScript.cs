using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    public float EnemyLevel = 1;
    public float EnemyHp = 1;
    public float speed = 1;
    public GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHp <= 0)
        {
            Debug.Log("The Enemy Has died");
            Destroy(this.gameObject);
        }
    }
}
