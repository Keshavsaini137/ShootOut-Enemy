using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
	[SerializeField] protected GameObject Flash;

	// Update is called once per frame
	void Update () {
		if (GlobalAmmo.LoadedAmmo >= 1)
		{

			if (Input.GetButtonDown("Fire1"))
			{
				AudioSource gunsound = GetComponent<AudioSource>();
				gunsound.Play();
				Flash.SetActive(true);
				MuzzleOff();
				GetComponent<Animation>().Play("Gun_Shot");
				//GetComponent.< Animation > ().Play("Gun_Shot");
				GlobalAmmo.LoadedAmmo -= 1;
			}
		}
	}

	IEnumerator MuzzleOff()
	{
		yield return new  WaitForSeconds(0.1f);
		Flash.SetActive(false);
	}
}
