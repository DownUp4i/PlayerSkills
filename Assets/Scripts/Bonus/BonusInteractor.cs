using UnityEngine;

public class BonusInteractor : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    public Bonus PickedBonusEffect;

    private void OnTriggerEnter(Collider other)
    {
        Bonus bonus = other.GetComponent<Bonus>();

        if (bonus != null)
        {
            if (PickedBonusEffect == null)
            {
                PickedBonusEffect = bonus;

                PickedBonusEffect.PickUp();
            }
        }
    }
}
