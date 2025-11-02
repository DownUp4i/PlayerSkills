using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    public float TimeToDesroyBullet { get; private set; } = 1f;

    private void Update()
    {
        Destroy(gameObject, TimeToDesroyBullet);
    }
}
