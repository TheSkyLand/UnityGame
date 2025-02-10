using UnityEngine;

using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float BaseDamage = 50;
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
            Attack();
        }
    }
    public virtual void Attack()
    {
        StartCoroutine(Attackf());
        Debug.Log("worked");
    }
    private IEnumerator Attackf()
    {
        Debug.Log("worked");
        Player.GetComponent<PlayerScript>().changeHpBux(+20);
        yield return new WaitForSeconds(1);
    }
}
