using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinsihUI : MonoBehaviour
{
    public GameObject Rank1Car;
    public GameObject Rank2Car;
    public GameObject Rank1Label;
    public GameObject Rank2Label;
    public GameObject Rank1Total;
    public GameObject Rank2Total;
    public GameObject Rank1Best;
    public GameObject Rank2Best;

    
    public RawImage CarFill;
    public RawImage RankFill;

    public GameObject FinishCanvas;
    [SerializeField]
    private float BestTime;
    [SerializeField]
    private float TotalTime;
    [SerializeField]
    private float BotBestTime;
    [SerializeField]
    private float BotTotalTime;

    

    
    void Start()
    {
        //for test
        /*
        BestTime = PlayerPrefs.GetFloat("BestTime");
        TotalTime = PlayerPrefs.GetFloat("TotalTime");
        BotBestTime = PlayerPrefs.GetFloat("BotBestTime");
        BotTotalTime = PlayerPrefs.GetFloat("BotTotalTime");*/
        

    }
   
    void Update()
    {
        if(FinishCanvas.activeSelf == true)
        {
            BestTime = PlayerPrefs.GetFloat("BestTime",0);
            TotalTime = PlayerPrefs.GetFloat("TotalTime",0);
            BotBestTime = PlayerPrefs.GetFloat("BotBestTime",0);
            BotTotalTime = PlayerPrefs.GetFloat("BotTotalTime",10000);

            
            if (TotalTime < BotTotalTime)
            {
                Rank1Car.GetComponent<Text>().text = "Player";
                Rank1Car.GetComponent<Text>().color = new Color(0, 0, 0);
                Rank1Label.GetComponent<Text>().color = new Color(0, 0, 0);
                TimeSpan time = TimeSpan.FromSeconds(TotalTime);
                RankFill.rectTransform.anchoredPosition = new Vector3(-301, 127, 0);
                CarFill.rectTransform.anchoredPosition = new Vector3(-144.01f, 127, 0);
                Rank1Total.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
                time = TimeSpan.FromSeconds(BestTime);
                Rank1Best.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");

                Rank2Car.GetComponent<Text>().text = "Bot1";
                Rank2Car.GetComponent<Text>().color = new Color(255, 255, 255);
                Rank2Label.GetComponent<Text>().color = new Color(255, 255, 255);
                if (BotTotalTime != 10000)
                {
                    time = TimeSpan.FromSeconds(BotTotalTime);
                    Rank2Total.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
                    time = TimeSpan.FromSeconds(BotBestTime);
                    Rank2Best.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
                }
                else
                {
                    Rank2Total.GetComponent<Text>().text = "Running...";
                    Rank2Best.GetComponent<Text>().text = "Running...";
                }
            }
            else
            {
                Rank2Car.GetComponent<Text>().text = "Player";
                Rank2Car.GetComponent<Text>().color = new Color(0, 0, 0);
                Rank2Label.GetComponent<Text>().color = new Color(0, 0, 0);
                TimeSpan time = TimeSpan.FromSeconds(TotalTime);
                RankFill.rectTransform.anchoredPosition = new Vector3(-301, 85, 0);
                CarFill.rectTransform.anchoredPosition = new Vector3(-144.01f, 85, 0);
                Rank2Total.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
                time = TimeSpan.FromSeconds(BestTime);
                Rank2Best.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");


                Rank1Car.GetComponent<Text>().text = "Bot1";
                Rank1Car.GetComponent<Text>().color = new Color(255, 255, 255);
                Rank1Label.GetComponent<Text>().color = new Color(255, 255, 255);
                time = TimeSpan.FromSeconds(BotTotalTime);
                Rank1Total.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
                time = TimeSpan.FromSeconds(BotBestTime);
                Rank1Best.GetComponent<Text>().text = time.ToString("mm':'ss'.'fff");
            }
            
            
        }
    }


}
