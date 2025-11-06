using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthUI;
    [SerializeField] Player _player;

    private void Update()
    {
        string _currentHealthUI = $"Çהמנמגüו: {_player.Health.CurrentHealth} / {_player.Health.MaxHealth}";
        _healthUI.text = _currentHealthUI;
    }
}
