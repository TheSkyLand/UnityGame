using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    protected float speed = 10f;
    protected float damage; // ���������� ����� ������
    public float health; // ���������� ������ � �����
    protected GameObject player; // ������ ������
    public Transform playerPos;

    // ������� ��� �������� ����� (�����������), �� ���� �������� ������ ����� �������� ������ �����
    public void changeHpBux(float i)
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
