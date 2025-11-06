using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : Bonus
{
    [SerializeField] private Player _playerHealth;
    private int _value = 100;

    public override void Use()
    {
        base.Use();
        _playerHealth.Health.ChangeHealth(_value);
        Destroy(gameObject);
    }

}
