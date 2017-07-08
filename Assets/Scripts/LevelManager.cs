using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

	public void loadLevel(string name)
	{
		Debug.Log("Level load requested for:" + name);
		SceneManager.LoadScene(name);
	}

	public void quitRequest()
	{
		Debug.Log("I want to quit");
		Application.Quit();
	}

}
