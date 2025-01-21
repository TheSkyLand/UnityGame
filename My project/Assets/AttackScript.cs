
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using static UnityEngine.Color;
using static UnityEngine.GraphicsBuffer;

public class AttackScript : MonoBehaviour
{

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
            // transform.localRotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Mathf.Clamp(transform.rotation.z, -15, 15));
            // transform.rotation = Quaternion.Euler(new Vector3(Mathf.Sin(Time.time * AttackSpeed) * AttackSpeed, 0, 1));
            transform.Rotate(Vector3.up, AttackSpeed * Time.deltaTime);
            Debug.Log("Attack initialized");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Got Button up");
        }

    }
}

    