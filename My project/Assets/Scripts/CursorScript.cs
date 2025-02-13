using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public bool isPushed; // Boolean-переменная, проверяющая, нажата ли ЛКМ
    public GameObject cursor; // Сами объекты

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Это для того,чтобы объект следовал за мышью, а чтобы объект не оказывался в бездне мира, переводим это дело в мировые координаты

        RaycastHit hit; // Луч из камеры
        if (Physics.Raycast(ray, out hit))
        {
              var newPos = hit.point; // Новая позиция
              newPos.y += 0.1f; // Прибавляем к Y ( Чтобы объекты не падали за карту )
              transform.position = newPos; // Задаем в качестве позиции newPos
            
        }
    }
}
