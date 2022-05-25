using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class devLightToggle : MonoBehaviour
{
	public float intensity;
	private Light light;
	void Start()
	{
		light = GetComponent<Light>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			light.enabled = !light.enabled;
			light.intensity = intensity;
		}
	}
}