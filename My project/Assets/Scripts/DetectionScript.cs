using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
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
            if (player.IsDestroyed() == true)
            {
                StopAllCoroutines();

            }
            else
            {
                StartCoroutine(FollowPlayer());
            }
        }
    }
    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "GameController")
        {
            StopAllCoroutines();
        }
        else
        {
            StartCoroutine(FollowPlayer());
        }
    }

    public IEnumerator FollowPlayer()
    {
        var playerPos = player.transform.position;
        playerPos.y = transform.position.y;
        enemy.transform.LookAt(playerPos);
        Debug.Log("worked");
        yield return new WaitForSeconds(1);
        Debug.Log("worked1");
    }
}
