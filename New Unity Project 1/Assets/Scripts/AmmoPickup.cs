using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] protected AudioSource ammoSound;
    [SerializeField] protected GameObject objectiveLabel;
    [SerializeField] protected GameObject objectiveComplete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        objectiveLabel = GameObject.Find("Canvas/ObjectivesLabel");
        //Debug.Log(ObjectiveLabel);
        /*if(GlobalAmmo.LoadedAmmo == 0){
        GlobalAmmo.LoadedAmmo += 10;
        ObjectiveComplete.SetActive(true);
        this.gameObject.SetActive(false);
        }
        else{*/
        if (other.tag == "ThePlayer")
        {
            //Debug.Log(col);
            ammoSound.Play();

            GlobalAmmo.CurrentAmmo += 10;
            if (objectiveLabel.activeSelf)
            {
                objectiveComplete.SetActive(true);
            }

            this.gameObject.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
