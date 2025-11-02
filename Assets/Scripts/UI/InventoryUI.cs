using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _inventoryUI;
    [SerializeField] private Inventory _inventory;

    void Update()
    {
        string _currentBonusEffectUI = _inventory._currentBonus != null ? _inventory._currentBonus.Name : "Пусто";
        _inventoryUI.text = $"Инвентарь: {_currentBonusEffectUI}";
    }
}
