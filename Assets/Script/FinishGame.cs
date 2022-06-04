using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class FinishGame : MonoBehaviour
{

    public GameObject FinishCube;
    public GameObject Car;
    public GameObject BotCar;
    public GameObject Canvas;
    public GameObject FinishCanvas;
    public ParticleSystem SpeedParticle;
    public AudioSource FinalMusic;
    public Component[] AllAudio;
    public Component[] AllPlayerAudio;

    private void Start()
    {    
        AllAudio = BotCar.GetComponents(typeof(AudioSource));
        AllPlayerAudio = Car.GetComponents(typeof(AudioSource));
    }
    IEnumerator OnTriggerEnter()
    {
        
        this.GetComponent<BoxCollider>().enabled = false;
        // disalbe car control and sound
        Car.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        Car.GetComponent<CarController>().enabled = false;
        Car.GetComponent<CarUserControl>().enabled = false;
        Car.GetComponent<CarAudio>().enabled = false;
        foreach (AudioSource a in AllPlayerAudio)
        {
            Destroy(a);
        }
        Car.SetActive(true);
        // disalbe AIcar sound
        BotCar.SetActive(false);
        BotCar.GetComponent<CarAudio>().enabled = false;
        foreach(AudioSource a in AllAudio)
        {
            Destroy(a);
        }
        SpeedParticle.Stop();
        //background Music stop

        Canvas.SetActive(false);
        FinishCanvas.SetActive(true);
        BotCar.SetActive(true);
        //camera change to finish rotate
        FinishCube.SetActive(true);
        FinalMusic.loop = true;
        FinalMusic.Play();
        yield return new WaitForSeconds(1.5f);
        CarController.m_Topspeed = 200;
    }
}
