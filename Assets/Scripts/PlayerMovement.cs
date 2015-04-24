using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 0.1f;

    private Transform _cameraTransform;
    private CharacterController _characterController;

	void Start ()
	{
        _cameraTransform = transform.Find("PlayerCamera");
	    _characterController = GetComponent<CharacterController>();
	}
	
    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        var input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        var motion = new Vector3(input.x * MoveSpeed, 0, input.z * MoveSpeed);
        motion = Quaternion.Euler(0, _cameraTransform.transform.rotation.eulerAngles.y, 0)*motion;

        _characterController.Move(motion);
    }
}
