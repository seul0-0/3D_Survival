using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerCondition condition;

    public ItemData itemData;
    public Action addItem;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();
    }
    
    public void Heal(float amount)
    {
        condition?.Heal(amount);
    }

    public void RestoreHunger(float amount)
    {
        condition?.Eat(amount);
    }

    public void ApplySpeedBoost(float multiplier, float duration)
    {
        {
            controller?.ApplySpeedBoost(multiplier, duration);   // ← 반드시 실제 호출로
        }
        
    }


}