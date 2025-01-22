using UnityEngine;
using UnityEngine.UIElements;

public class RangedAttack : MonoBehaviour
{
    public float BaseDamage = 1;
    public float ProjectileSpeed = 1;
    public float AttackSpeed = 1;
    [SerializeField] private GameObject Projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnClick();
        }
    }
    public void OnClick()
    {
        Instantiate(Projectile, transform.position, transform.rotation);
        //transform.position += ProjectileSpeed * Time.deltaTime;
    }
}
