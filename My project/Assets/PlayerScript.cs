using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float MaxPlayerHealth = 1000;
    public float PlayerHealth = 100;
    public float PlayerSpeed = 5.0F;
    public float horizontalSpeed = 1.0F;
    public float verticalSpeed = 1.0F;
    public float MaxSpeed = 10F;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerHealth);
        // forward movement + pressing W
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * PlayerSpeed * Time.deltaTime;
            Debug.Log("the w is pressed");
        }
        // release w
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("the w key has been released");
        }
        // backward movement + pressing S
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * PlayerSpeed * Time.deltaTime;
            Debug.Log("the S is pressed");
        }
        // releasing S
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("the S key has been released");
        }
        // right? movement + pressing D
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * PlayerSpeed * Time.deltaTime;
            Debug.Log("the D is pressed");
        }
        // releasing D
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("the D key has been released");
        }
        // left? movement + pressing A
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * PlayerSpeed  * Time.deltaTime;
            Debug.Log("the A is pressed");
        }
        // releasing A
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("the A key has been released");
        }

        if (Input.GetMouseButtonDown(0))   
        {
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Left mouse button locked");
        }

        if (Input.GetKey(KeyCode.LeftShift)) {
            // Set current speed to run if shift is down
            PlayerSpeed = MaxSpeed;
        }
        else
        {
            // Otherwise set current speed to walking speed
            PlayerSpeed = 10f;
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Left mouse button unlocked");
        }   

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, h, 0);
        }

        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
