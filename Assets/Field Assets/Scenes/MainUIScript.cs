using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIScript : MonoBehaviour
{
    public AudioSource soundPlayer;
    public Button btnStar;
    public Button btnDifficulty;
    public Button btnSetting;

    // Start is called before the first frame update
    void Start()
    {
        btnStar.onClick.AddListener(ClickStart);
        btnDifficulty.onClick.AddListener(ClickDifficulty);
        btnSetting.onClick.AddListener(ClickSetting);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ClickStart()
    {
        soundPlayer.Play();
        SceneManager.LoadScene("Drift Track");
    }

    private void ClickDifficulty()
    {
        soundPlayer.Play();
        SceneManager.LoadScene("Difficulty");
    }

    private void ClickSetting()
    {
        soundPlayer.Play();
    }
      
}