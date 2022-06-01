using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarScriptControl : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject BotCarControl;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        BotCarControl.GetComponent<CarController>().enabled = true;
    }

    
}
