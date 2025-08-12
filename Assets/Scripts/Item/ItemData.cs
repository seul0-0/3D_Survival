using System;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable,
    Resource
}

public enum ConsumableType
{
    Health,
    Hunger,
    SpeedBoost
}

[Serializable]
public class ItemDataConsumable
{
    public ConsumableType Type;
    public float value;
    public float duration;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")] 
    public bool canStack;
    public int maxStackAmont;
    
    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
