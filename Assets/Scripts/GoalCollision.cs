using UnityEngine;
using System.Collections;

public class GoalCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("found end");
            col.gameObject.rigidbody.AddForce(new Vector3(0,5,0));
        }
    }
}
