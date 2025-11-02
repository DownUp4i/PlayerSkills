using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] protected Transform _character;
    [SerializeField] protected CharacterController _characterController;

    protected void ProcessMoveTo(Vector3 direction, float speed)
    {
        Vector3 normalizedDirection = direction.normalized;
        _characterController.Move(normalizedDirection * speed * Time.deltaTime);
    }

    protected void ProcessRotateTo(Vector3 direction, float speed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        _character.rotation = Quaternion.RotateTowards(_character.rotation, lookRotation, speed * Time.deltaTime);
    }
}
