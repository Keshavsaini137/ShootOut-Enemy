using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{

	public GameObject ThePlayer;
	public float TargetDistance;
	public float AllowedRange = 30;
	public GameObject TheEnemy;
	public float EnemySpeed;
	public int AttackTrigger = 0;
	public RaycastHit Shot;

	public int IsAttacking;
	public GameObject ScreenFlash;
	public AudioSource Hurt01;
	public AudioSource Hurt02;
	public AudioSource Hurt03;
	//public GameObject zombieAttackSound;
	public AudioSource attackSound;
	public int PainSound;


	void Update ()
	{
		transform.LookAt (ThePlayer.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)) {
			TargetDistance = Shot.distance;
			if (TargetDistance < AllowedRange) {
				EnemySpeed = 0.1f;
				//Debug.Log (AttackTrigger);
				if (AttackTrigger == 0) {
					TheEnemy.GetComponent<Animation> ().Play ("Walking");
					transform.position = Vector3.MoveTowards (transform.position, ThePlayer.transform.position, Time.deltaTime * 3);
				
				}
			} else {
				EnemySpeed = 0.0000f;
				TheEnemy.GetComponent<Animation> ().Play ("Idle");
			}

		}

		if (AttackTrigger == 1) {
			//Debug.Log (AttackTrigger);
			if (IsAttacking == 0) {
				StartCoroutine (EnemyDamage ());
			}

			EnemySpeed = 0.0000f;
			TheEnemy.GetComponent<Animation> ().Play ("Attacking");
		}

	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "ThePlayer") {
			AttackTrigger = 1;
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.tag == "ThePlayer") {
			AttackTrigger = 0;
		}
	}


	IEnumerator EnemyDamage ()
	{
		IsAttacking = 1;
		//attackSound = zombieAttackSound.GetComponent<AudioSource> ();

		PainSound = Random.Range (1, 4);
		//attackSound.Play ();
		yield return new WaitForSeconds (0.9f);
		//attackSound.Play ();
		ScreenFlash.SetActive (true);
		GlobalHealth.PlayerHealth -= 2;

		if (PainSound == 1) {
			attackSound.Play ();
			Hurt01.Play ();


		}

		if (PainSound == 2) {
			attackSound.Play ();
			Hurt02.Play ();

		}

		if (PainSound == 3) {
			attackSound.Play ();
			Hurt03.Play ();

		}

		yield return new WaitForSeconds (0.05f);
		ScreenFlash.SetActive (false);
		yield return new WaitForSeconds (1);
		IsAttacking = 0;

	}

}
