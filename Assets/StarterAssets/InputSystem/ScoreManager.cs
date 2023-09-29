using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;


    int score = 0;
    int highscore = 0; 

    private void Awake() {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
       scoreText.text = "Points: " + score.ToString();
       highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint() {
        score += 1; 
        scoreText.text = "Points: " + score.ToString();
        if(highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
    public void SubPoint() {
        score--;
        if(score > 0) {
            scoreText.text = "Points: " + score.ToString();
        } else {
            score = 0; 
            scoreText.text = "Points: " + score.ToString();
        } 
            
    }
}
