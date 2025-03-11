using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class EnemyAttack : MonoBehaviour
{
    public float BaseDamage = 30;
    public float AttackSpeed = 2;
    public PlayerScript Player;
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

            StartCoroutine(Attackf());
            Debug.Log("worked");
        }
    }
    private IEnumerator Attackf()
    {
        while (true)
        {
            Debug.Log("worked");
            GetComponent<PlayerHp>().ChangeHpBux(+BaseDamage);
            yield return new WaitForSeconds(AttackSpeed * Time.deltaTime);
        }
    }
}
