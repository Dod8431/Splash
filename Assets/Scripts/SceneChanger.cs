using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	void StartButton()
	{
 		StartCoroutine(StartLevel());
	}

	void OptionsButton()
	{
 		SceneManager.LoadScene("OPTIONS", LoadSceneMode.Single);
	}

	void ExitButton()
	{
 		Application.Quit();
	}

	IEnumerator StartLevel()
	{
		yield return new WaitForSeconds(2.9f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		yield return null;
	}
}
