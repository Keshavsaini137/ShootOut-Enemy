using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

	[SerializeField] public static int CurrentScore;
	[SerializeField] public int InternalScore;
	[SerializeField] public GameObject ScoreText;
	[SerializeField] public static int score;
	[SerializeField] public int highScore;
	[SerializeField] public static int Show1;
	[SerializeField] public static int Show2;
	[SerializeField] public static int Show3;

	// Use this for initialization
	void Start () {
		Show1 = PlayerPrefs.GetInt("HighScore1");
		Show2 = PlayerPrefs.GetInt("HighScore2");
		Show3 = PlayerPrefs.GetInt("HighScore3");
		//Debug.Log(PlayerPrefs.GetInt("HighScore1"));
		//Debug.Log(Show2);
		//Debug.Log(Show3);
	}

	// Update is called once per frame
	void Update () {
        ScoreText.GetComponent<Text>().text = "" + score;
		highScore = score;


		if (score >= Show1)
		{
			PlayerPrefs.SetInt("HighScore3", Show2);
			PlayerPrefs.SetInt("HighScore2", Show1);

			PlayerPrefs.SetInt("HighScore1", score);

		}

		if (score < PlayerPrefs.GetInt("HighScore1") && score > PlayerPrefs.GetInt("HighScore3") || (score == PlayerPrefs.GetInt("HighScore2")))
		{
			PlayerPrefs.SetInt("HighScore3", Show2);
			PlayerPrefs.SetInt("HighScore2", score);

		}

		if (score < PlayerPrefs.GetInt("HighScore2") && score == PlayerPrefs.GetInt("HighScore3"))
			PlayerPrefs.SetInt("HighScore3", score);

	}
}
