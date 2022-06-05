using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishButton : MonoBehaviour
{
    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
        PlayerPrefs.DeleteAll();
    }
    public void LoadScene(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.DeleteAll();

    }
    public void QuitGame()
    {
        Debug.Log("game quitted");
        Application.Quit();
    }
}
