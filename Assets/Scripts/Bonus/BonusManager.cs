using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Player _player;
    [SerializeField] private PlayerMovement _playerMovement;

    private void Update()
    {
        if (_player.HasUsedBonusEffect == true)
        {
            switch (_inventory._currentBonus.Name)
            {
                case "Здоровье":
                    _player.ChangeHealth(100);
                    break;

                case "Скорость":
                    _playerMovement.ChangeSpeed(20f);
                    break;
            }

            _player.HasUsedBonusEffect = false;
        }
    }
}
