using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour
{
	// Use this for initialization
	void Awake ()
	{
	    RenderSettings.skybox = GetComponent<Skybox>().material;
	    RenderSettings.ambientLight = Color.black;
	}
}
