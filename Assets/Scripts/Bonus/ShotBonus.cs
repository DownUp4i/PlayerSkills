using UnityEngine;

public class ShotBonus : Bonus
{
    [SerializeField] private BulletPrefab _bulletPrefab;
    [SerializeField] private float _bulletSpeed = 40f;

    private BulletPrefab _bullet;

    private Vector3 direction;

    private bool _isBulletInstantiate = false;

    private void Start()
    {
        Initialize("Выстрел");
    }

    public override void ShowEffects()
    {
        _effectAfterUse.transform.rotation = _bonusInteractor.rotation;
        _effectAfterUse.transform.position = _bonusInteractor.position;
        _effectAfterUse.Play();
    }

    public override void Use()
    {
        if (_isBulletInstantiate == false)
        {
            _bullet = Instantiate(_bulletPrefab, _bonusInteractor.position, _bonusInteractor.rotation);
            _isBulletInstantiate = true;
            ShowEffects();
        }
    }

    private void Update()
    {
        if (_bullet != null)
        {
            _bullet.transform.Translate(Vector3.forward * _bulletSpeed * Time.deltaTime, Space.Self);
            Destroy(gameObject, _bulletPrefab.TimeToDesroyBullet);
        }
    }
}
