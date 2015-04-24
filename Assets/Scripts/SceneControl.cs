using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour
{
	void Awake ()
	{
	    RenderSettings.skybox = GetComponent<Skybox>().material;
        RenderSettings.ambientLight = new Color(37 / 256f, 50 / 256f, 71 / 256f);
	}
}
