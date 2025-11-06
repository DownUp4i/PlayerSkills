using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private BonusInteractor _bonusInteractor;
    [SerializeField] private Vector3 _bonusOffset;

    private Bonus _ñurrentBonus;

    private Vector3 _pickUpScale;

    public Bonus ÑurrentBonus { get; private set; }

    private void Awake()
    {
        _pickUpScale = Vector3.one * 0.7f;
    }

    private void Update()
    {
        Add();

        if (ÑurrentBonus != null)
        {
            UpdateBonusPosition();
        }
    }

    private void UpdateBonusPosition()
    {
        ÑurrentBonus.transform.position = _bonusInteractor.transform.position + _bonusOffset;
        ÑurrentBonus.transform.rotation = Quaternion.identity;
        ÑurrentBonus.transform.localScale = _pickUpScale;
    }
    public void Add()
    {
        ÑurrentBonus = _bonusInteractor.PickedBonusEffect;
    }
}
