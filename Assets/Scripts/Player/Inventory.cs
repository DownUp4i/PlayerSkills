using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] BonusInteractor _bonusInteractor;
    public Bonus _currentBonus;

    private void Update()
    {
        if (!gameObject.GetComponent<Bonus>())
        {
            Add();

            if (_currentBonus != null)
            {
                _currentBonus.PickUp();
            }
        }
    }

    public void Add()
    {
        _currentBonus = _bonusInteractor.PickedBonusEffect;
    }
}
