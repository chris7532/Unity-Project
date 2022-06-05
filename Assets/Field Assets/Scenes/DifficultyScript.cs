using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    public static int difficulty; 
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
        SceneManager.LoadScene("MainUI");
    }

    private void ClickHard()
    {
        difficulty = 1;
        SceneManager.LoadScene("MainUI");
    }
}