using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 0.1f;

    private Camera _camera;
    private CharacterController _characterController;

	void Start ()
	{
	    _camera = GetComponentInChildren<Camera>();
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
        motion = Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0)*motion;

        _characterController.Move(motion);
    }
}
