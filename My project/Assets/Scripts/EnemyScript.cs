using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    protected float speed = 10f;
    protected float damage; // количество урона игроку
    public float health; // количество жизней у врага
    protected GameObject player; // объект игрока
    public Transform playerPos;

    // Функция для движения врага (виртуальная), то есть дочерний скрипт будет изменять данный метод
    public void changeHpBux(float i)
    {
        health  -= i;
    }
    // Публичный метод для изменения состояния врага (жив/мертв), можем обращаться к этому методу
    // с других скриптов, но изменять в дочерни классах не можем!

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
