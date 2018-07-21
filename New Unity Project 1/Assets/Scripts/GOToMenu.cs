using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOToMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine (Holds ());
		GlobalHealth.PlayerHealth = 10;
	}

	IEnumerator Holds ()
	{
		

		Cursor.visible = true;
		yield return new WaitForSeconds (3.0f);

		SceneManager.LoadScene (1);

	}


}
