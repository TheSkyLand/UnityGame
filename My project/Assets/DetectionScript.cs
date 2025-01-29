using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DetectionScript : MonoBehaviour
{
    public EnemyScript Enemy; 
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (gameObject.name.Contains("Player"))
        {
            Enemy.transform.position = Vector3.MoveTowards(transform.position, target.position, Enemy.speed * Time.deltaTime);
        }
    }
}
