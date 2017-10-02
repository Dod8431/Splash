using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	void StartButton()
	{
 		SceneManager.LoadScene("LVL_1", LoadSceneMode.Single);
	}

	void OptionsButton()
	{
 		SceneManager.LoadScene("OPTIONS", LoadSceneMode.Single);
	}

	void ExitButton()
	{
 		Application.Quit();
	}
}
