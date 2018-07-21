static var CurrentScore : int;
var InternalScore : int;

var ScoreText : GameObject;
static var score : int;
var highScore : int;
static var Show1 : int;
static var Show2 : int;
static var Show3 : int;


function Start(){
    Show1 = PlayerPrefs.GetInt("HighScore1");
    Show2 = PlayerPrefs.GetInt("HighScore2");
    Show3 = PlayerPrefs.GetInt("HighScore3");
    //Debug.Log(PlayerPrefs.GetInt("HighScore1"));
    //Debug.Log(Show2);
    //Debug.Log(Show3);
}

function Update(){
    
    ScoreText.GetComponent.<Text>().text = "" + score;
    highScore = score;


    if(score >= Show1){
    PlayerPrefs.SetInt("HighScore3",Show2);
    PlayerPrefs.SetInt("HighScore2",Show1);

    PlayerPrefs.SetInt("HighScore1",score);

    }

    if(score < PlayerPrefs.GetInt("HighScore1") && score > PlayerPrefs.GetInt("HighScore3") || (score == PlayerPrefs.GetInt("HighScore2"))){
    PlayerPrefs.SetInt("HighScore3",Show2);
    PlayerPrefs.SetInt("HighScore2", score );

    }

    if(score < PlayerPrefs.GetInt("HighScore2") && score == PlayerPrefs.GetInt("HighScore3"))
    PlayerPrefs.SetInt("HighScore3", score );

}

