using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    public float speed; // ���������� ����� ������
    public float health; // ���������� ������ � �����
    protected GameObject player; // ������ ������
    public Transform playerPos;

    // ������� ��� �������� ����� (�����������), �� ���� �������� ������ ����� �������� ������ �����
    public void ChangeHpBux(float i)
    {
        health  -= i;
    }
    // ��������� ����� ��� ��������� ��������� ����� (���/�����), ����� ���������� � ����� ������
    // � ������ ��������, �� �������� � ������� ������� �� �����!

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
