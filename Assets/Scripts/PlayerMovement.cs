using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 _motion;
    public float PrevX;
    public float PrevZ;
    private Vector3 _facing;

    private Vector3 _input;
    private Camera _camera;
    private CharacterController _characterController;

	// Use this for initialization
	void Start ()
	{
	    _camera = GetComponentInChildren<Camera>();
	    _characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        _input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        PrevX = transform.position.x;
        PrevZ = transform.position.z;

        _motion = new Vector3(_input.x*MoveSpeed, 0, _input.z*MoveSpeed);

        _motion = Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0)*_motion;

        _characterController.Move(_motion);
    }
}
