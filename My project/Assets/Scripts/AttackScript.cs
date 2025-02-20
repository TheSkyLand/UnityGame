using UnityEngine;
public class AttackScript : MonoBehaviour
{
    private Animator anim;
    public GameObject enemy;
    public GameObject Player;
    public GameObject weapon;
    public EnemyAttack Attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        anim.Play("Idle");

    }
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "GameController")
        {
            // If the GameObject has the same tag as specified, output this message in the console  
            Player.GetComponent<PlayerScript>().ChangeHpBux(+Attack.BaseDamage);
            anim.Play("KatanaAttack");
        }
    }

}

    