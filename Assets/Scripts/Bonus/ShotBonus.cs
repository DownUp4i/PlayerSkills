using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class ShotBonus : Bonus
{
    [SerializeField] private Bullet _bulletPrefab;
    private bool _isBulletInstantiate = false;
    private Bullet _bullet;

    public override void Use()
    {
        if (_isBulletInstantiate == false)
        {
            _bullet = Instantiate(_bulletPrefab, BonusEffectPosition.position, BonusEffectPosition.rotation);
            _isBulletInstantiate = true;
            _bullet.Launch();
            base.Use();
        }
        Destroy(gameObject, _bullet.TimeToDesroyBullet);
    }
}
