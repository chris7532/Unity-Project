using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUIScript : MonoBehaviour
{
    public AudioSource soundPlayer;
    public TextMeshProUGUI m_MyText;
    public Button btnStar;
    public Button btnDifficulty;
    public Button btnSetting;

    // Start is called before the first frame update
    void Start()
    {
        if(DifficultyScript.difficulty==0){
            m_MyText.SetText("Preview - Easy");
        }
        else{
            m_MyText.SetText("Preview - Hard");
        }

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
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene("Difficulty");
    }

    private void ClickSetting()
    {
        soundPlayer.Play();
    }
      
}