#pragma strict
import UnityEngine.UI;
import UnityEngine.SceneManagement;

var highScoreText1 : GameObject;
var scoreHolder1 : Text;
var highScoreToPrint1 : int;

var highScoreText2 : GameObject;
var scoreHolder2 : Text;
var highScoreToPrint2 : int;

var highScoreText3 : GameObject;
var scoreHolder3 : Text;
var highScoreToPrint3 : int;


function Start () {
	highScoreText1 = GameObject.Find("Canvas/First/High Score");
    scoreHolder1 = highScoreText1.GetComponent.<Text>();

    highScoreToPrint1 = PlayerPrefs.GetInt("HighScore1");
    scoreHolder1.text = highScoreToPrint1.ToString();

    highScoreToPrint2 = PlayerPrefs.GetInt("HighScore2");
    scoreHolder2.text = highScoreToPrint2.ToString();

    highScoreToPrint3 = PlayerPrefs.GetInt("HighScore3");
    scoreHolder3.text = highScoreToPrint3.ToString();

    //Debug.Log(PlayerPrefs.GetInt("HighScore1"));
}

function Update () {
	if(Input.GetButtonDown("Cancel")){
    SceneManager.LoadScene(1);

    }
}

function Reset(){
    PlayerPrefs.DeleteAll();
    scoreHolder1.text = "0";
    scoreHolder2.text = "0";
    scoreHolder3.text = "0";
    }


