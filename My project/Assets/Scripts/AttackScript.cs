using UnityEngine;
public class AttackScript : MonoBehaviour
{
    private Animator anim;
    public GameObject enemy;
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
            
        }
    }
}

    