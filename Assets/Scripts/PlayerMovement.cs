using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public float MaxSpeed;
    private Vector3 _motion;
    public float PrevX;
    public float PrevZ;

    private Vector3 _input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        _input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        PrevX = rigidbody.position.x;
        PrevZ = rigidbody.position.z;

        if (Mathf.Abs(_motion.x) > 0)
            _motion.x -= MoveSpeed*Mathf.Sign(_motion.x);
        if (_motion.x < MoveSpeed)
            _motion.x = 0;

        if (Mathf.Abs(_motion.z) > 0)
            _motion.z -= MoveSpeed * Mathf.Sign(_motion.z);
        if (_motion.z < MoveSpeed)
            _motion.z = 0;


        _motion += _input*MoveSpeed;

        if (_motion.x > MaxSpeed)
            _motion.x = MaxSpeed;
        if (_motion.x < -MaxSpeed)
            _motion.x = -MaxSpeed;

        if (_motion.z > MaxSpeed)
            _motion.z = MaxSpeed;
        if (_motion.z < -MaxSpeed)
            _motion.z = -MaxSpeed;

        rigidbody.position += _motion;
    }

    public void FindGoal()
    {
        return;
    }
}
