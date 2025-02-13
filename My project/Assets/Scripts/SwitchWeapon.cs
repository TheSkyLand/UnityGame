using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    [SerializeField] GameObject Bow;
    [SerializeField] GameObject Sword;
    int weapon = 0;
    public void ChooseWeapon(string weapon)
    {
        switch (weapon)
        {
            case "Bow":
                Bow.SetActive(true);
                Sword.SetActive(false);
                break;
            case "Sword":
                Bow.SetActive(false);
                Sword.SetActive(true);
                break;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bow.SetActive(false);
        Sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChooseWeapon("Bow");
            weapon = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChooseWeapon("Sword");
            weapon = 2;
        }
        if (Input.GetMouseButton(0))
        {
            switch (weapon)
            {
                case 1:
                    // ������ ��������� ������ ����� ������ Gun � ������� ������� Shoot()
                    Bow.GetComponent<RangedWeapon>().Shoot();
                    // pistol.GetComponent<Gun>().Update();
                    break;
                case 2:
                    Sword.GetComponent<WeaponScript>().Attack();
                    // avtomat.GetComponent<Gun>().Update();
                    break;
            }
        }
    }
}
