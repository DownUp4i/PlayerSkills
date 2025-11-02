using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    private int _maxHealth = 100;
    private int _currentHealth = 20;

    public int CurrentHealth => _currentHealth;
    public int MaxHealth => _maxHealth;

    private KeyCode useBonusEffectKey = KeyCode.F;
    public bool HasUsedBonusEffect;

    private void Update()
    {
        if (Input.GetKeyDown(useBonusEffectKey))
        {
            if(_inventory._currentBonus != null)
            {
                HasUsedBonusEffect = true;
                _inventory._currentBonus.Use();
            }
        }
    }

    public void ChangeHealth (int health)
    {
        if(health > _maxHealth)
            _currentHealth = _maxHealth;

        _currentHealth = health;
    }
}
