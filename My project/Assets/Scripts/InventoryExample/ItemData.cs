using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public GameObject model;
    [TextArea]
    public string description;

    public int startingAmmo;
    public int startingCondition;
}
[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int condition;
    public int ammo;

    public ItemInstance(ItemData itemData)
    {
        itemType = itemData;
        condition = itemData.startingCondition;
        ammo = itemData.startingAmmo;
    }
}