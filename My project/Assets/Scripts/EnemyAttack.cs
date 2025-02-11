using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float BaseDamage = 50;
    public float AttackSpeed = 1;
    public PlayerScript Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider player)
    {

        if (player.tag == "GameController")
        {

            StartCoroutine(Attackf());
            Debug.Log("worked");
        }
    }
    private IEnumerator Attackf()
    {
        Debug.Log("worked");
        Player.GetComponent<PlayerScript>().changeHpBux(+BaseDamage);
        yield return new WaitForSeconds(AttackSpeed * Time.deltaTime);
        Player.GetComponent<PlayerScript>().changeHpBux(+BaseDamage);
    }
}
