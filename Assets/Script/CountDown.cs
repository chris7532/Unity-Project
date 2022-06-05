using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource GoAudio;
    public AudioSource CountAudio;

    public GameObject CarScriptControl;
    public GameObject CountDownUI;

    public Camera first_surround_camera;
    public Camera second_user_camera;

    public GameObject Timer;
    public GameObject TimerAI;
    void Start()
    {
        CarController.m_Topspeed = 200;
        StartCoroutine(StartCountDown());

    }

    
    IEnumerator StartCountDown()
    {

        yield return new WaitForSeconds(7);
        first_surround_camera.enabled = false;
        second_user_camera.enabled = true;

        CountDownUI.GetComponent<Text>().text = "3";
        CountAudio.Play();
        CountDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownUI.SetActive(false);

        CountDownUI.GetComponent<Text>().text = "2";
        CountAudio.Play();
        CountDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownUI.SetActive(false);

        CountDownUI.GetComponent<Text>().text = "1";
        CountAudio.Play();
        CountDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownUI.SetActive(false);

        CountDownUI.GetComponent<Text>().text = "GO!";
        GoAudio.Play();
        //Timer enabled
        Timer.SetActive(true);
        TimerAI.SetActive(true);
        // background music start

        CountDownUI.SetActive(true);
        CarScriptControl.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownUI.SetActive(false);

    }
}
