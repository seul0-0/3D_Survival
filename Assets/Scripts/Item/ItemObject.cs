using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        var player = CharacterManager.Instance.Player;

        // ① 아이템 효과 적용
        foreach (var c in data.consumables)
        {
            switch (c.Type)
            {
                case ConsumableType.Health:
                    player.Heal(c.value);                // 체력 ↑
                    break;

                case ConsumableType.Hunger:
                    player.RestoreHunger(c.value);                 // 포만감 ↑ (배고픔 감소)
                    break;

                case ConsumableType.SpeedBoost:
                    player.ApplySpeedBoost(c.value, c.duration); // 이속 버프
                    break;
            }
        }

        // ② 인벤토리 처리(네 기존 로직 유지)
        player.itemData = data;
        player.addItem?.Invoke();

        // ③ 아이템 제거
        Destroy(gameObject);
    }


}