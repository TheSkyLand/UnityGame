using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            Debug.Log("the w is pressed");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("the w key has been released");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("the S is pressed");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("the S key has been released");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("the D is pressed");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("the D key has been released");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("the A is pressed");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("the A key has been released");
        }
        
        /*
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, 50000)&&Input.GetMouseButtonDown(1))
        {
            nav.SetDestination(hit.point);
            nav.Resume ();
        }
        if (Vector3.Distance (transform.position, nav.destination) < 0.3f)
        {
            nav.Stop ();
        }

        
        Vector3 curMove = transform.position - _prevPosition;
        float curSpeed = curMove.magnitude / Time.deltaTime;
        _prevPosition = transform.position;


        
        if (Input.GetKeyDown(KeyCode.Mouse0))   
        {
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Left mouse button locked");

        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Left mouse button unlocked");
        }
        */
    }
}
