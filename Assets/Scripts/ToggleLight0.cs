using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight0 : MonoBehaviour
{

	Renderer Renderer;

	// Use this for initialization
	void Start()
	{
		Renderer = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update()
	{
		// Toggle light on/off when L key is pressed.
		if (Input.GetKeyUp(KeyCode.F))
		{
			Renderer.enabled = !Renderer.enabled;
		}
	}
}