using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

	public float targetTime = 5.0f;
	public Text displayTimer;
	bool starts = false;

	public Text highScore;

	public Text playerScore;
	int hit = 0;

	// Use this for initialization
	void Start ()
	{
		
		highScore.text = PlayerPrefs.GetInt ("HighScore", 0).ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.anyKey) {
			starts = true;
		}

		if (starts) {
			targetTime -= Time.deltaTime;
			displayTimer.text = targetTime.ToString ("f2");
		}

		if (targetTime <= 0) {
			starts = false;

			SceneManager.LoadScene (2);

		}

		if (Input.GetButtonDown ("Fire1")) {
			hit = hit + 1;
		}

		playerScore.text = "Score: " + hit.ToString ();


		if (hit >= PlayerPrefs.GetInt ("HighScore")) {
			
			PlayerPrefs.SetInt ("HighScore", hit);
			highScore.text = hit.ToString ();
		}

	}

}
