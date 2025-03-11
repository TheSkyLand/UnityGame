using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryInstance : ScriptableObject
{
    public ItemData newItemType;
    public List<ItemInstance> items = new();

    void Start()
    {
        items.Add(new ItemInstance(newItemType));
    }
}