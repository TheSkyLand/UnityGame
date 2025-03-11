 using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public SwitchWeapon Access;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ItemMeleeWeapon")
        {
            // Удали этот объект
            // print("Взял");
            Destroy(other.gameObject);
            Access.HasWeapon = true;

        }
        if (other.tag == "ItemRangedWeapon")
        {
            // Удали этот объект
            // print("Взял");
            Destroy(other.gameObject);
            Access.HasWeapon = true;
        }
        if (other.tag == "Item")
        {


        }
    }
}