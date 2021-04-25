using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
	
	GameObject lastObjective;
	public GameObject ObjectiveLabel;
	
	// Use this for initialization
	void Start ()
	{
		lastObjective = GameObject.Find ("Canvas/ObjectivesLabel/Objective03/BlueTick");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (lastObjective.activeSelf) {
			//Destroy (gameObject, 2);

			ObjectiveLabel.SetActive (false);
		}
	}
}
