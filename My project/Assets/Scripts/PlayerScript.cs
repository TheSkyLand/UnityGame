using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public float PlayerSpeed = 5.0F;
    public float horizontalSpeed = 1.0F;
    public float verticalSpeed = 1.0F;
    public float MaxSpeed = 10F;
    public GameObject cursor;
    public Transform cursorPos;
    public GameObject Inventory;



    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("playerX"))
        {
            // Локально определилои координаты сохранения
            float x = PlayerPrefs.GetFloat("playerX");
            float y = PlayerPrefs.GetFloat("playerY");
            float z = PlayerPrefs.GetFloat("playerZ");

            // телепортировали игрока на нужное место
            transform.position = new Vector3(x, y, z);
        }                
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log("TEST");
            Inventory.SetActive(true);
        }
        else
        {
            Inventory.SetActive(false);
        }

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
    }
}
