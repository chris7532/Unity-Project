using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BotTimer : MonoBehaviour
{
    public static float CurrentTime;
    public GameObject BotFinalWay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForStart());
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(CurrentTime);
        
    }
    public IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(10);
        BotFinalWay.SetActive(true);
    }

}