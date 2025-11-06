using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] protected ParticleSystem EffectAfterUse;
    [SerializeField] protected Transform BonusEffectPosition;

    [SerializeField] private Vector3 _effectOffet;

    [SerializeField] public string Name;

    private Vector3 _pickUpScale;

    private void Awake()
    {
        _pickUpScale = transform.localScale * 0.7f;
    }

    public void PickUp()
    {
        gameObject.GetComponent<BonusAnimation>().TurnOffAnimation();
        Debug.Log("PICKUP");
    }

    public virtual void Use()
    {
        SetEffectPosition();
        ShowEffects();
    }

    public virtual void SetEffectPosition ()
    {
        EffectAfterUse.transform.position = BonusEffectPosition.position;
    }

    public void ShowEffects()
    {
        EffectAfterUse.Play();
    }
}
