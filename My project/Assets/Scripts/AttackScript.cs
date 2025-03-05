using UnityEngine;
public class AttackScript : MonoBehaviour
{
    private Animator anim;
    public GameObject Enemy;
    public DetectionScript pursuer;
    public EnemyAttack attacker;
    public GameObject Player;
    public GameObject weapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = weapon.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "GameController")
        {
            // If the GameObject has the same tag as specified, output this message in the console  
            anim.Play("KatanaAttack");
            Player.GetComponent<PlayerScript>().ChangeHpBux(+attacker.BaseDamage);
            var script = pursuer.GetComponent<DetectionScript>();
            script.FollowPlayer();
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        var script = pursuer.GetComponent<DetectionScript>();
        script.FollowPlayer();
    }
}

    