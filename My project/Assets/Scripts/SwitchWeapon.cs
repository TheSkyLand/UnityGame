using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Secondary;
    int weapon = 0;
    public void ChooseWeapon(string weapon)
    {
        switch (weapon)
        {
            case "Main":
                Main.SetActive(true);
                Secondary.SetActive(false);
                break;
            case "Secondary":
                Main.SetActive(false);
                Secondary.SetActive(true);
                break;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Main.SetActive(false);
        Secondary.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChooseWeapon("Main");
            weapon = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChooseWeapon("Secondary");
            weapon = 2;
        }
        if (Input.GetMouseButton(0))
        {
            switch (weapon)
            {
                case 1:
                    // Объект пистолета должен найти скрипт Gun и вызвать функцию Shoot()
                    Main.GetComponent<WeaponScript>().Attack(); 
                    // pistol.GetComponent<Gun>().Update();
                    break;
                case 2:
                    Secondary.GetComponent<RangedWeapon>().Shoot();
                    // avtomat.GetComponent<Gun>().Update();
                    break;
            }
        }
    }
}
