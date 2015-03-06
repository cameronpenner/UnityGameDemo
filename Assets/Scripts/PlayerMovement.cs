using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public float MaxSpeed;
    private Vector3 _input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        _input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	    if (rigidbody.velocity.magnitude < MaxSpeed)
	    {
	        rigidbody.AddForce(_input*MoveSpeed);
	    }
	}
}
