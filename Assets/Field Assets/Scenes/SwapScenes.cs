using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Drift Track"){
            
            Music.instance.GetComponent<AudioSource>().Pause();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
        }
        if(SceneManager.GetActiveScene().name == "MainUI" && !Music.instance.GetComponent<AudioSource>().isPlaying){
            Music.instance.GetComponent<AudioSource>().Stop();
            Music.instance.GetComponent<AudioSource>().Play();
        }       
    }
}