using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public bool isPushed; // Boolean-����������, �����������, ������ �� ���
    public GameObject cursor; // ���� �������

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ��� ��� ����,����� ������ �������� �� �����, � ����� ������ �� ���������� � ������ ����, ��������� ��� ���� � ������� ����������

        RaycastHit hit; // ��� �� ������
        if (Physics.Raycast(ray, out hit))
        {
              var newPos = hit.point; // ����� �������
              newPos.y += 0.1f; // ���������� � Y ( ����� ������� �� ������ �� ����� )
              transform.position = newPos; // ������ � �������� ������� newPos
            
        }
    }
}
