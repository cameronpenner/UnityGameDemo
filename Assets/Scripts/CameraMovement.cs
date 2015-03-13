using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    private Vector3 lookAt;
    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("Player");
        lookAt = player.transform.position;
        transform.LookAt(lookAt);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    lookAt = Vector3.Lerp(lookAt, player.transform.position,0.05f);
	    transform.LookAt(lookAt);
	}
}
