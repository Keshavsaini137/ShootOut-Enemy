using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene01 : MonoBehaviour
{

	public GameObject ThePlayer;
	public GameObject Cam1;
	public GameObject Cam2;
	public GameObject Cam3;
	public GameObject TheUI;
	public GameObject nearZombie;
	public GameObject cutSceneMusic;
	public GameObject backgroundMusic;


	// Use this for initialization
	void Start ()
	{
		StartCoroutine (CutSceneBegin ());
	}

	IEnumerator CutSceneBegin ()
	{
		cutSceneMusic.SetActive (true);
		backgroundMusic.SetActive (false);
		yield return new WaitForSeconds (5.4f);
		Cam3.SetActive (true);
		Cam1.SetActive (false);
		yield return new WaitForSeconds (8.1f);
		Cam2.SetActive (true);
		Cam3.SetActive (false);
		yield return new WaitForSeconds (10.1f);
		cutSceneMusic.SetActive (false);
		backgroundMusic.SetActive (true);
		ThePlayer.SetActive (true);
		TheUI.SetActive (true);
		nearZombie.SetActive (true);
		Cam2.SetActive (false);

	}


}
