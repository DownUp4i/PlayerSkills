using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : Bonus
{
    private void Start()
    {
        Initialize("Скорость");
    }

    public override void Use ()
    {
        base.Use();
        Destroy(gameObject);
    }
}
 