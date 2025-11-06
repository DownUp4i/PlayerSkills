using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 10f;

    private Rigidbody _rigidBody;

    public float TimeToDesroyBullet { get; private set; } = 2f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Destroy(gameObject, TimeToDesroyBullet);

    }
    public void Launch()
    {
        _rigidBody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }
}
