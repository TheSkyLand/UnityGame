using Unity.VisualScripting;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 10.0f;
    public float AttackSpeed = 1.0f;
    float smooth = 2.5f;
    float tiltAngle = 60.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        if (Input.GetMouseButton(0))
        {
            float MaxAttackSpeed = 2.0f;
            while (AttackSpeed > MaxAttackSpeed)
            {
                Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                AttackSpeed = AttackSpeed + Time.deltaTime;
            }
            Debug.Log("Attack initialized");
        }

    }

}