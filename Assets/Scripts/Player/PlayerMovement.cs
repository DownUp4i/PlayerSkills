using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    [SerializeField] private float _speedMovement = 5f;
    [SerializeField] private float _speedRotation = 600f;

    private float _deadZone = 0.1f;

    private string _horizontalInput = "Horizontal";
    private string _verticalInput = "Vertical";

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw(_horizontalInput), 0, Input.GetAxisRaw(_verticalInput));

        ProcessMoveTo(direction, _speedMovement);

        if (direction.magnitude <= _deadZone)
            return;

        ProcessRotateTo(direction, _speedRotation);
    }

    public void ChangeSpeed (float speed)
    {
        _speedMovement = speed;
    }
}
