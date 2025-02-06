using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    protected float damage; // количество урона игроку
    protected float health; // количество жизней у врага
    protected GameObject player; // объект игрока
    bool dead = false; // живой ли враг

    // Функция для движения врага (виртуальная), то есть дочерний скрипт будет изменять данный метод
    public void changeHpBux(int i)
    {
        health  -= i;
    }
    // Публичный метод для изменения состояния врага (жив/мертв), можем обращаться к этому методу
    // с других скриптов, но изменять в дочерни классах не можем!
    public void OnDeath()
    {
        dead = true;
        // Изменение анимации при попадания по врагу
        GetComponent<Animator>().SetBool("death", true);
        // Отключение вращения врага, после смерти
        GetComponent<CharacterController>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Находим главного персонажа по скррипту, который к нему прикреплён
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
