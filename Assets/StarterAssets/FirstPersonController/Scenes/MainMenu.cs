using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("levelSelect");
    }

    public void quitGame()
    {
        Application.Quit();
    }
    public void level1()
    {
        SceneManager.LoadScene("level1");
        Cursor.visible = false;
    }
    public void level2()
    {
        SceneManager.LoadScene("level2");
        Cursor.visible = false;
    }
    public void highscoreScreen()
    {
        SceneManager.LoadScene("highscoreScreen");
    }
    public void back() {
        SceneManager.LoadScene(0);
    }
}
