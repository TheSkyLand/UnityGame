using UnityEngine;

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
    void OnTriggerEnter(Collider trigger)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (trigger.gameObject.name.Contains("Character"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            Debug.Log(Player.PlayerHealth);
            Player.PlayerHealth -= BaseDamage;
        }
    }
}
