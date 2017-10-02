﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D coll)
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	void RestartLevel()
	{
	 	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
