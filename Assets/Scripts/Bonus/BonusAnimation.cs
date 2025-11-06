using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusAnimation : MonoBehaviour
{
    [SerializeField] private float _speedRotate = 90f;

    private Vector3 _defaultPosition;
    public bool IsAnimated;

    private void Start()
    {
        TurnOnAnimation();
        _defaultPosition = transform.localPosition;
    }

    private void Update()
    {
        if(IsAnimated)
        {
            transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
            transform.position = _defaultPosition + Vector3.up * Mathf.Sin(Time.time) / 5;
        }
    }

    public void TurnOnAnimation() => IsAnimated = true;
    public void TurnOffAnimation() => IsAnimated = false;

}
