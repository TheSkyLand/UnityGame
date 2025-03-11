using UnityEngine;

public class InstanceItemContainer : MonoBehaviour
{
    public ItemInstance item;

    public ItemInstance TakeItem()
    {
        Destroy(gameObject);
        return item;
    }
}