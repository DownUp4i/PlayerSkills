using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _inventoryUI;
    [SerializeField] private Inventory _inventory;

    void Update()
    {
        string _currentBonusEffectUI = _inventory.ÑurrentBonus != null ? _inventory.ÑurrentBonus.Name : "Ïóñòî";
        _inventoryUI.text = $"Èíâåíòàğü: {_currentBonusEffectUI}";
    }
}
