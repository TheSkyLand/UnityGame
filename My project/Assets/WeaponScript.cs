using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class WeaponScript : MonoBehaviour
{
    public float BaseDamage = 1.0f;
    public float AttackSpeed = 1000.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Attack initialized");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Got Button up");
        }
        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("collision detected");
        }
    }
}