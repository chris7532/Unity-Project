using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource GoAudio;
    public AudioSource CountAudio;

    public GameObject CarScriptControl;
    public GameObject CountDownUI;

    void Start()
    {
        StartCoroutine(StartCountDown());
    }

    
    IEnumerator StartCountDown()
    {
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
        // background music start

        CountDownUI.SetActive(true);
        CarScriptControl.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDownUI.SetActive(false);

    }
}
