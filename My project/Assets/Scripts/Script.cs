using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Script : MonoBehaviour
{

    public GameObject player; // ��� ������ ������
    private Vector3 offset;  

    void Start () 
    {        
        offset = transform.position - player.transform.position;
    }

    void LateUpdate () 
    {        
        transform.position = player.transform.position + offset;
        if (player.IsDestroyed())
        {
            offset = transform.position;
        }
    }
}
