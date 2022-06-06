using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    public static int difficulty = 0; 
    public AudioSource soundPlayer;
    public Button btnEasy;
    public Button btnHard;

    // Start is called before the first frame update
    void Start()
    {
        btnEasy.onClick.AddListener(ClickEasy);
        btnHard.onClick.AddListener(ClickHard);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ClickEasy()
    {
        
        difficulty = 0;
        StartCoroutine(Wait());
    }

    private void ClickHard()
    {
        difficulty = 1;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        soundPlayer.Play();
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene("MainUI");
    }
}