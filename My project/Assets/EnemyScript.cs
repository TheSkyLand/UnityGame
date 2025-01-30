using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    protected int demage; // ���������� ����� ������
    protected int health; // ���������� ������ � �����
    protected GameObject player; // ������ ������
    bool dead = false; // ����� �� ����

    // ������� ��� �������� ����� (�����������), �� ���� �������� ������ ����� �������� ������ �����
    public virtual void Move() { }

    // ����� ��� ������������ ����� �����, ������������� � �������� ������ (������������)
    public virtual void Attack() { }

    // ��������� ����� ��� ��������� ��������� ����� (���/�����), ����� ���������� � ����� ������
    // � ������ ��������, �� �������� � ������� ������� �� �����!
    public void OnDeath()
    {
        dead = true;
        // ��������� �������� ��� ��������� �� �����
        GetComponent<Animator>().SetBool("death", true);
        // ���������� �������� �����, ����� ������
        GetComponent<CharacterController>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        // ������� �������� ��������� �� ��������, ������� � ���� ���������
        //player = FindObjectOfType<PlayerMove>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ���� ��� (�� ����)
        if (!dead)
        {
            Move();
            Attack();
        }
    }
}
