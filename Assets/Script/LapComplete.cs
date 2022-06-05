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
    private float BestTime;
    private float TotalTime;
    private int LapTotal = 2;
    
    //完成賽圈
    public GameObject FinishTrigger;
    //相對名次
    public static int RelativeRank = 0;
    void Start() {
        LapTimeRecord = new List<float>();
    }

    void Update()
    {
        if(LapCount == LapTotal)
        {
            //FinishTrigger.SetActive(true);
            
        }
    }
    void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "PlayerCar") {

            LapCount +=1;
            Debug.Log("Complete time: "+ LapTimer.CurrentTime);           
            LapTimeRecord.Add(LapTimer.CurrentTime);
            BestTime = FindMin(LapTimeRecord);
            TimeSpan time = TimeSpan.FromSeconds(BestTime);
            BestBox.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
            LapTimer.CurrentTime = 0;
            LapBox.GetComponent<Text>().text = LapCount.ToString();     
            if(LapCount == LapTotal)
            {
                FinishTrigger.SetActive(true);
                PlayerPrefs.SetFloat("BestTime",BestTime);
                TotalTime = TotalLapTime(LapTimeRecord);
                PlayerPrefs.SetFloat("TotalTime", TotalTime);
            }
            FinalWay.SetActive(false);
            HalfWay.SetActive(true);
            
        }
        
            
    }
    float FindMin(List<float> LapTimeRecord){
        float min = 10000.0f;
        foreach (float item in LapTimeRecord)
        {
            if(item<min)
            min = item;
        }
        return min;
    }
    float TotalLapTime(List<float> LapTimeRecord)
    {
        float total = 0;
        foreach (float item in LapTimeRecord)
        {
            total += item;
        }
        return total;
    }
    

}
