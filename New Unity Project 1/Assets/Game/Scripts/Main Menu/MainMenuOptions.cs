using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuOptions : MonoBehaviour
{

	public void PlayGame ()
	{
		//PauseMenu.Resume ();
		SceneManager.LoadScene (2);
	}

	public void HighScore ()
	{
		SceneManager.LoadScene (4);
	}

	public void Credits ()
	{
		SceneManager.LoadScene (5);
	}

	void Start ()
	{
		//Debug.Log (PauseMenu.thePlayer);
		//PauseMenu.thePlayerScript = true;
		Time.timeScale = 1f;


		//Cursor.visible = true;
		GlobalHealth.PlayerHealth = 10;
	}

	public void ExitGame ()
	{
		Application.Quit ();
	}



}
