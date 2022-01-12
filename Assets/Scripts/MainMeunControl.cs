using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeunControl : MonoBehaviour
{
    public void Game(string name)
    {

        SceneManager.LoadSceneAsync(name);
    }
    public void ManMeun()
    {
        Application.LoadLevel("ManMeun");

    }
    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
        
    }
    public void Resetgame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
