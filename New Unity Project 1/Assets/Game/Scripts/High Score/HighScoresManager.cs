using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoresManager : MonoBehaviour {

	[SerializeField] public GameObject highScoreText1;
	[SerializeField] public Text scoreHolder1;
	[SerializeField] public int highScoreToPrint1;

	[SerializeField] public GameObject highScoreText2;
	[SerializeField] public Text scoreHolder2;
	[SerializeField] public int highScoreToPrint2;

	[SerializeField] public GameObject highScoreText3;
	[SerializeField] public Text scoreHolder3;
	[SerializeField] public int highScoreToPrint3;

	// Use this for initialization
	void Start () {
		highScoreText1 = GameObject.Find("Canvas/First/High Score");
		scoreHolder1 = highScoreText1.GetComponent<Text>();

		highScoreToPrint1 = PlayerPrefs.GetInt("HighScore1");
		scoreHolder1.text = highScoreToPrint1.ToString();

		highScoreToPrint2 = PlayerPrefs.GetInt("HighScore2");
		scoreHolder2.text = highScoreToPrint2.ToString();

		highScoreToPrint3 = PlayerPrefs.GetInt("HighScore3");
		scoreHolder3.text = highScoreToPrint3.ToString();

		//Debug.Log(PlayerPrefs.GetInt("HighScore1"));
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel"))
		{
			SceneManager.LoadScene(1);

		}
	}


	protected void Reset()
	{
		PlayerPrefs.DeleteAll();
		scoreHolder1.text = "0";
		scoreHolder2.text = "0";
		scoreHolder3.text = "0";
	}
}
