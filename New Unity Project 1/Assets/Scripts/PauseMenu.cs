using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenu;
	public GameObject pauseBackGround;
	public GameObject[] zombies;
	public GameObject thePlayer;
	public GameObject gunMachanics;
	public GameObject M9;
	//public static bool thePlayerScript;
	public GameObject pauseCamera;



	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Cancel")) {

			//SceneManager.LoadScene (1);

			if (GameIsPaused && pauseMenu.activeSelf) {
				Resume ();
			} else {
				Pause ();
			}
		
		}

	}

	public void Resume ()
	{
		Debug.Log ("Resumed");
		pauseBackGround.SetActive (false);
		pauseMenu.SetActive (false);
		Time.timeScale = 1f;
		thePlayer.GetComponent<FirstPersonController> ().enabled = true;

		M9.SetActive (true);

		foreach (GameObject holder in zombies) {
			holder.SetActive (true);
		}
	}

	void Pause ()
	{
		pauseBackGround.SetActive (true);
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
		thePlayer.GetComponent<FirstPersonController> ().enabled = false;
		Cursor.visible = true;

		//pauseCamera.SetActive(true);
		//thePlayer.SetActive(false);
		//thePlayer.GetComponent<FirstPersonController>();
		//gunMachanics.SetActive(false);
		M9.SetActive (false);

		//Cursor.visible = true;

		foreach (GameObject holder in zombies) {
			holder.SetActive (false);
		}
		GameIsPaused = true;
	}

	public void Menu ()
	{
		//PauseMenu.thePlayerScript = true;
		SceneManager.LoadScene (1);
	}

}