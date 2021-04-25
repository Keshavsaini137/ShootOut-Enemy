using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour
{
    [SerializeField] protected GameObject UpCurs;
    [SerializeField] protected GameObject DownCurs;
    [SerializeField] protected GameObject LeftCurs;
    [SerializeField] protected GameObject RightCurs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //UpCurs.GetComponent("Animator").enabled = true;
                //DownCurs.GetComponent("Animator").enabled = true;
                //LeftCurs.GetComponent("Animator").enabled = true;
                //RightCurs.GetComponent("Animator").enabled = true;
                //WaitingAnim();
            }
        }
    }

    protected void WaitingAnim()
    {
        //yield WaitForSeconds(0.1);
        //UpCurs.GetComponent("Animator").enabled = false;
        //DownCurs.GetComponent("Animator").enabled = false;
        //LeftCurs.GetComponent("Animator").enabled = false;
        //RightCurs.GetComponent("Animator").enabled = false;
    }
}
