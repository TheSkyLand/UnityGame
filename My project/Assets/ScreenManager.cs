using UnityEngine;
using UnityEngine.UI;


public class ScreenManager : MonoBehaviour
{
    public WeaponScript Weapon;
    public Text AmmoText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateAmmoText(Weapon.maxAmmo, Weapon.maxAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateAmmoText(float currentAmmo, float maxAmmo)
    {
        AmmoText.text = currentAmmo + "/" + maxAmmo;
    }
}
