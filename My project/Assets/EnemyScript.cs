using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    protected float damage; // ���������� ����� ������
    protected float health; // ���������� ������ � �����
    protected GameObject player; // ������ ������
    bool dead = false; // ����� �� ����

    // ������� ��� �������� ����� (�����������), �� ���� �������� ������ ����� �������� ������ �����
    public void changeHpBux(int i)
    {
        health  -= i;
    }
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
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "GameController")
        {
            Attack();
        }
    }
    public virtual void Attack()
    {
        StartCoroutine(Attackf());
        Debug.Log("worked");
    }
    private IEnumerator Attackf()
    {
        Debug.Log("worked");
        player.GetComponent<PlayerScript>().changeHpBux(-20);
        yield return new WaitForSeconds(1);
    }
}
