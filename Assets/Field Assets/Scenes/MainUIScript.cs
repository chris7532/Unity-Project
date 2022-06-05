using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIScript : MonoBehaviour
{
    public Button btnStar;
    public Button btnDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        btnStar.onClick.AddListener(ClickStart);
        btnDifficulty.onClick.AddListener(ClickDifficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ClickStart()
    {
        SceneManager.LoadScene("Drift Track");
    }

    private void ClickDifficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }
      
}