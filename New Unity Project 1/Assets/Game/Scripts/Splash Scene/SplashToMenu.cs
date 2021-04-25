using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (SplashFinish ());
		
	}


	IEnumerator SplashFinish ()
	{
		yield return new WaitForSeconds (10.6f);
		SceneManager.LoadScene (1);
	}

}
