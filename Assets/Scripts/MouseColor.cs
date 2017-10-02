using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseColor : MonoBehaviour {

	public bool red;
	public bool blue;
	public bool white;
	public GameObject wheel;
	public Vector2 mousePos;

	void Update()
	{
		mousePos = Input.mousePosition;
		mousePos.x -= Screen.width/2;
		mousePos.y -= Screen.height/2;
		if(red)
		{
			blue = false;
			white = false;
		}

		if(blue)
		{
			red = false;
			white = false;
		}

		if(white)
		{
			red = false;
			blue = false;
		}
	}

	void ChangeToRed()
	{
		white = false;
		blue = false;
		red = true;
	}

	void ChangeToBlue()
	{
		white = false;
		red = false;
		blue = true;
	}

	void ChangeToWhite()
	{
		red = false;
		blue = false;
		white = true;
	}

	
}
