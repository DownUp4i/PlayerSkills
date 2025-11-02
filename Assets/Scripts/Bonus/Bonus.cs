using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] protected Transform _bonusInteractor;
    [SerializeField] private Vector3 _offset;

    [SerializeField] protected ParticleSystem _effectAfterUse;
    [SerializeField] protected Vector3 _effectOffet;

    public string Name { get; private set; }

    private Vector3 _pickUpScale;

    private void Awake()
    {
        _pickUpScale = transform.localScale * 0.7f;
    }

    public void Initialize(string name)
    {
        Name = name;
    }

    public void PickUp()
    {
        transform.position = _bonusInteractor.position + _offset;
        transform.rotation = Quaternion.identity;
        transform.localScale = _pickUpScale;

        gameObject.GetComponent<BonusAnimation>().IsAnimated = false;
    }

    public virtual void Use()
    {
        ShowEffects();
    }

    public virtual void ShowEffects()
    {
        _effectAfterUse.transform.position = _bonusInteractor.position - _effectOffet;
        _effectAfterUse.Play();
    }
}
