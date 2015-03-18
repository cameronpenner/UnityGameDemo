using System;
using Assets.Scripts;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public float MaxSpeed;
    private Vector3 _motion;
    public float PrevX;
    public float PrevZ;
    private Vector3 _facing;

    private Vector3 _input;
    private Camera _camera;

	// Use this for initialization
	void Start ()
	{
	    _camera = GetComponent<Camera>();
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

        _motion = new Vector3(_input.x*MaxSpeed, 0, _input.z*MaxSpeed);

        _motion = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0)*_motion;

        transform.position = new Vector3(transform.position.x + _motion.x,
                                         transform.position.y,
                                         transform.position.z + _motion.z);
    }

    private void OnCollisionEnter(Collision col)
    {
            Debug.Log("bump!");
        if(col.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3(PrevX, transform.position.y, PrevZ);
        }
    }

//    private void keyboard

    public void FindGoal()
    {
        return;
    }
}
