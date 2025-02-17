using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyScript : MonoBehaviour
{
    public float speed; // количество урона игроку
    public float health; // количество жизней у врага
    // ‘ункци€ дл€ движени€ врага (виртуальна€), то есть дочерний скрипт будет измен€ть данный метод
    public void ChangeHpBux(float i)
    {
        health  -= i;
    }
    // ѕубличный метод дл€ изменени€ состо€ни€ врага (жив/мертв), можем обращатьс€ к этому методу
    // с других скриптов, но измен€ть в дочерни классах не можем!

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
