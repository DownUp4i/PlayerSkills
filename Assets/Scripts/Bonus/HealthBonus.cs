using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : Bonus
{
    private void Start()
    {
        Initialize("Çהמנמגüו");
    }

    public override void Use()
    {
        base.Use();
        Destroy(gameObject);
    }
}
