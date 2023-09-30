using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameEnd : MonoBehaviour
{
    public static GameEnd instance;
    public int currentEnemies = 0;
    public AudioClip victory;
    private float resetDelay = 1; 

    private void Awake() {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void subtractEnemy() {
        currentEnemies--;
        if (currentEnemies <= 0) {
            Debug.Log("All enemies are dead!!!!!!!!");
            AudioSource.PlayClipAtPoint (victory, transform.position);
            ScoreManager.instance.scoreText.text = "All enemies defeated! Returning to main menu...";
            ScoreManager.instance.highscoreText.text = "";
            ScoreManager.instance.addToScores(PlayerPrefs.GetInt("highscore", 0));
            Time.timeScale = 0.5f;
            Invoke ("ReturnMainMenu", resetDelay);
        }
    }

    void ReturnMainMenu() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
