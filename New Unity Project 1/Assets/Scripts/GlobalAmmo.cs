using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    [SerializeField] public static int CurrentAmmo;
    [SerializeField] protected int InternalAmmo;
    [SerializeField] protected GameObject AmmoDisplay;
    [SerializeField] public static int LoadedAmmo = 0;
    [SerializeField] protected int InternalLoaded;
    [SerializeField] protected GameObject LoadedDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;

    }
}
