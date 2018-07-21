using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

	GameObject highScoreObject;
	Text text;

	// Use this for initialization
	void Start ()
	{
		highScoreObject = GameObject.Find ("Canvas/High Score");
		text = highScoreObject.GetComponent<Text> ();

		text.text = "HelloWorld";

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
