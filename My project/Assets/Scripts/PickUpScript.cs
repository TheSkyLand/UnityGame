 using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    [SerializeField] GameObject Ranged;
    [SerializeField] GameObject Melee;
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
        if (other.name == "RangedWeapon")
        {
            // ����� ���� ������
            // print("����");
            Destroy(other.gameObject);
            Ranged.SetActive(true);
        }
        if (other.name == "MeleeWeapon")
        {
            // ����� ���� ������
            // print("����");
            Destroy(other.gameObject);
            Ranged.SetActive(true);
        }
    }
}