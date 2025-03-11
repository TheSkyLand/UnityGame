using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public float PlayerHealth;
    public bool IsDead = false;
    public float MaxPlayerHealth = 1000F;
    public Text Text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
            IsDead = true;
        }
        Text.text = "HP: " + PlayerHealth.ToString() + "/" + MaxPlayerHealth.ToString();
    }
    public void ChangeHpBux(float i)
    {

        PlayerHealth -= i;
    }
}
