using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampColor : MonoBehaviour {

	public GameObject gc;
	public Material lampcolor;
	public Light lamplight;
	public Color white;
	public Color red;
	public Color blue;

	void Update()
	{	
		lampcolor.color = white;
		lamplight.color = white;
		
		if(gc.GetComponent<MouseColor>().white == true)
		{
			lampcolor.color = white;
			lamplight.color = white;
		}

		if(gc.GetComponent<MouseColor>().blue == true)
		{
			lampcolor.color = blue;
			lamplight.color = blue;
		}

		if(gc.GetComponent<MouseColor>().red == true)
		{
			lampcolor.color = red;
			lamplight.color = red;
		}
	}
}