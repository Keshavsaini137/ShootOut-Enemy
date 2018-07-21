using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
	public Text timerText;
	public float timerStartAt = 120.0f;
	public GameObject ThePlayer;
	bool startTimer = false;


	void Update ()
	{

		if (Input.GetButton ("Vertical")) {

			startTimer = true;


			/*timerStartAt = timerStartAt - Time.deltaTime;
			//Debug.Log (timerStartAt);

			string minutes = ((int)timerStartAt / 60).ToString ();
			string seconds = (timerStartAt % 60).ToString ();

			timerText.text = minutes + ":" + seconds;*/  //(timerStartAt.ToString ("f2"));

			if (timerStartAt <= 0) {
				//timerStartAt = 0.0f;
				SceneManager.LoadScene (3);
			}
		
		}

		if (startTimer) {
			timerStartAt = timerStartAt - Time.deltaTime;//1/fps in that time.
			//Debug.Log (timerStartAt);

			string minutes = ((int)timerStartAt / 60).ToString ();
			string seconds = (timerStartAt % 60).ToString ();//Remainder

			timerText.text = minutes + ":" + seconds;
		}

	}




}
