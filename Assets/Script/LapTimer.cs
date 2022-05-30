using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LapTimer : MonoBehaviour
{
    
    public static float CurrentTime;
    string TimeDisplay;
    string BestDisplay;
    public GameObject TimeBox;
    public GameObject BestBox;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
        TimeBox.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
    }
}
