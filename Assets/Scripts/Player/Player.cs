using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    public Health Health = new Health();

    private KeyCode useBonusEffectKey = KeyCode.F;
    public bool HasUsedBonusEffect;

    private void Update()
    {
        if (Input.GetKeyDown(useBonusEffectKey))
        {
            if(_inventory.ÑurrentBonus != null)
            {
                HasUsedBonusEffect = true;
                _inventory.ÑurrentBonus.Use();
            }
        }
    }
}
