using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LapComplete : MonoBehaviour
{
    //中間和終點check點
    public GameObject HalfWay;
    public GameObject FinalWay;
    //Timer UI
    public GameObject TimeBox;
    public GameObject BestBox;
    //圈數紀錄
    public GameObject LapBox;
    public int LapCount;

    public List<float> LapTimeRecord;
    private float bestTime;

    void Start() {
        LapTimeRecord = new List<float>();
    }
    void OnTriggerEnter(){

        
        Debug.Log("Complete time: "+ LapTimer.CurrentTime);
        LapTimeRecord.Add(LapTimer.CurrentTime);
        bestTime = findMin(LapTimeRecord);
        TimeSpan time = TimeSpan.FromSeconds(bestTime);
        BestBox.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
        LapTimer.CurrentTime = 0;
        LapCount +=1;
        LapBox.GetComponent<Text>().text = "Laps: "+LapCount.ToString();
        FinalWay.SetActive(false);
        HalfWay.SetActive(true);


    }
    float findMin(List<float> LapTimeRecord){
        float min = 10000.0f;
        foreach (float item in LapTimeRecord)
        {
            if(item<min)
            min = item;
        }
        return min;
    }
    

}
