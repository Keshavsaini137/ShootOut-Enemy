using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenuC : MonoBehaviour
{

	void Start ()
	{
		StartCoroutine (ReturnToMenu ());
	}

	IEnumerator ReturnToMenu ()
	{
		yield return new WaitForSeconds (11);
		SceneManager.LoadScene (1);
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Cancel")) {
			SceneManager.LoadScene (1);
		}
	}


}
