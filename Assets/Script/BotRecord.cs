using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.Vehicles.Car;

public class BotRecord : MonoBehaviour
{
    public GameObject BotFinalWay;
    public GameObject BotCar;
    public int BotLapCount;
    public List<float> BotLapTimeRecord;
    private float BotBestTime;
    private float BotTotalTime;
    private int BotLapTotal = 2;
    // Start is called before the first frame update
    void Start()
    {
        BotLapTimeRecord = new List<float>();
        
    }

    IEnumerator OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "aiCar")
        {
            BotLapCount += 1;
            Debug.Log("Bot Complete time: " + BotTimer.CurrentTime);
            BotLapTimeRecord.Add(BotTimer.CurrentTime);
            BotBestTime = FindMin(BotLapTimeRecord);
            TimeSpan time = TimeSpan.FromSeconds(BotBestTime);
            if (BotLapCount == BotLapTotal)
            {
                PlayerPrefs.SetFloat("BotBestTime", BotBestTime);
                BotTotalTime = TotalLapTime(BotLapTimeRecord);
                PlayerPrefs.SetFloat("BotTotalTime", BotTotalTime);
                BotCar.SetActive(false);
                CarController.m_Topspeed = 0.0f;
                BotCar.GetComponent<CarAIControl>().enabled = false;
                BotCar.GetComponent<CarController>().enabled = false;
                BotFinalWay.SetActive(false);
                BotCar.SetActive(true);
                CarController.m_Topspeed = 200;
            }
            BotTimer.CurrentTime = 0;            
            BotFinalWay.GetComponent<BoxCollider>().enabled = false;
            yield return new WaitForSeconds(3);
            BotFinalWay.GetComponent<BoxCollider>().enabled = true;
        }
    }


    float FindMin(List<float> LapTimeRecord)
    {
        float min = 10000.0f;
        foreach (float item in LapTimeRecord)
        {
            if (item < min)
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
