using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public EnemyScript Char;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "GameController")
        {

            StartCoroutine(FollowPlayer());
            Debug.Log("collided");
        }
    }
    private void OnTriggerExit(Collider player)
    {
        Char.speed = 0;
        StopCoroutine(FollowPlayer());
    }
    public IEnumerator FollowPlayer()
    {
        Char.speed += 1;
        while (true)
        {
            var playerPos = player.transform.position;
            playerPos.y = transform.position.y;
            enemy.transform.LookAt(playerPos);
            enemy.transform.position += transform.forward * Time.deltaTime * Char.speed;
            //enemy.transform.position += enemy.transform.forward * 2f * Time.deltaTime;
            yield return null;
        }
    }
}
