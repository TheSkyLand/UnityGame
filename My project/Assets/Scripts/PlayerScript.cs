using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using static UnityEngine.GraphicsBuffer;

public class PlayerScript : MonoBehaviour
{
    public float MaxPlayerHealth = 1000F;
    public float PlayerHealth = 100F;
    public float PlayerSpeed = 5.0F;
    public float horizontalSpeed = 1.0F;
    public float verticalSpeed = 1.0F;
    public float MaxSpeed = 10F;
    public GameObject cursor;
    public Transform cursorPos;
    public GameObject Player;
    public bool IsDead = false;
    public void ChangeHpBux(float i)
    {

        PlayerHealth -= i;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * PlayerSpeed * Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Confined;
            Debug.Log("Left mouse button locked");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Set current speed to run if shift is down
            PlayerSpeed = MaxSpeed;
        }
        else
        {
            // Otherwise set current speed to walking speed
            PlayerSpeed = 5f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Left mouse button unlocked");
        }




        var playerPos = cursor.transform.position;
        playerPos.y = transform.position.y;
        transform.LookAt(playerPos);

        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
            IsDead = true;
        }
    }
}
