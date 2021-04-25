using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunReloading : MonoBehaviour {

	[SerializeField] protected GunFire gunFire;
	[SerializeField] protected AudioSource ReloadSound;
	[SerializeField] protected GameObject CrossObject;
	[SerializeField] protected GameObject MechanicsObject;
	[SerializeField] protected int ClipCount;
	[SerializeField] protected int ReserveCount;
	[SerializeField] protected int ReloadAvailable;

	// Update is called once per frame
	void Update ()
	{
		ClipCount = GlobalAmmo.LoadedAmmo;
		ReserveCount = GlobalAmmo.CurrentAmmo;

		if (ReserveCount == 0)
		{
			ReloadAvailable = 0;

		}
		else
		{
			ReloadAvailable = 10 - ClipCount;
		}

		if (Input.GetButtonDown("Reload"))
		{
			if (ReloadAvailable >= 1)
			{
				if (ReserveCount <= ReloadAvailable)
				{
					GlobalAmmo.LoadedAmmo += ReserveCount;
					GlobalAmmo.CurrentAmmo -= ReserveCount;
					ActionReload();
				}
				else
				{
					GlobalAmmo.LoadedAmmo += ReloadAvailable;
					GlobalAmmo.CurrentAmmo -= ReloadAvailable;
					ActionReload();

				}
			}
			EnableScript();
		}

	}


	IEnumerator EnableScript()
	{
		yield return new WaitForSeconds(1.1f);
		//yield WaitForSeconds(1.1);
		gunFire.enabled = true;
		CrossObject.SetActive(true);
		MechanicsObject.SetActive(true);
	}

	protected void ActionReload()
	{
		gunFire.enabled = false;
		CrossObject.SetActive(false);
		MechanicsObject.SetActive(false);
		ReloadSound.Play();
		//GetComponent.< Animation > ().Play("HandGunReload");
		GetComponent<Animation>().Play("HandGunReload");
	}
}
