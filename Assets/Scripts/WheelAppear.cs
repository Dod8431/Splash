using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAppear : MonoBehaviour {

	public GameObject wheel;
	public Vector2 mousePos;

	void Update()
	{
		mousePos = Input.mousePosition;
		mousePos.x -= Screen.width/2;
		mousePos.y -= Screen.height/2;
	}

	void OnTouchDown()
	{
		wheel.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
		wheel.SetActive(true);
		wheel.GetComponent<Animator>().SetBool("appear", true);
	}

	void OnMouseDown()
	{
		wheel.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
		wheel.SetActive(true);
		wheel.GetComponent<Animator>().SetBool("appear", true);
		wheel.GetComponent<Animator>().SetBool("disappear", false);
	}
	
	void OnMouseDrag()
	{

	}

	void OnMouseUp()
	{
		wheel.GetComponent<Animator>().SetBool("disappear", true);
		wheel.GetComponent<Animator>().SetBool("appear", false);

	}
}
