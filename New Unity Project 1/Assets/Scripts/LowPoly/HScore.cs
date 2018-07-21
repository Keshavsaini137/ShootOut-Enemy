
using UnityEngine;
using UnityEngine.UI;

public class HScore : MonoBehaviour
{
	public Text highScore1;

	// Use this for initialization
	void Start ()
	{
		highScore1.text = PlayerPrefs.GetInt ("HighScore").ToString ();

	}

}
