using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedBonus : Bonus
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private float _value = 20f;

    public override void Use()
    {
        base.Use();
        Destroy(gameObject);

        _playerMovement.ChangeSpeed(_value);
    }
}
