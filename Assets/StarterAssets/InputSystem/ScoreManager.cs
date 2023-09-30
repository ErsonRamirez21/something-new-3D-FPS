using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;


    public int score = 0;
    public int highscore = 0; 
    List<int> tempList = new List<int>();

    private void Awake() {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        // Clear the tempList before populating it to avoid duplicate zeros
        tempList.Clear();

        // Get the list of previous highscores
        int listSize = PlayerPrefs.GetInt("list_size", 0);
        for (int i = 0; i < listSize; i++)
        {
            int score = PlayerPrefs.GetInt("list_element_" + i, 0);
            if (score > 0)
            {
                tempList.Add(score);
            }
        }
        
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Points: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint() {
        score += 1; 
        scoreText.text = "Points: " + score.ToString();
        if(highscore < score) {
            PlayerPrefs.SetInt("highscore", score);
        }
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
    
    public void addToScores(int highScore) {
        Debug.Log("current highscore is: " +  highScore);
        for(int i = 0; i < tempList.Count; i++) {
            Debug.Log("score " + tempList[i]);
        }
        Debug.Log("number of scores in tempList: " + tempList.Count);

        if(highScore != 0 && !tempList.Contains(highScore)) {
            tempList.Add(highScore);
            Debug.Log("Added highScore to tempList: " + highScore);
        }

        PlayerPrefs.SetInt("list_size", tempList.Count);
        for(int i = 0; i < tempList.Count; i++) {
            PlayerPrefs.SetInt("list_element_" + i, tempList[i]);
            Debug.Log("PlayerPrefs key list_element_" + i + " set to value: " + tempList[i]);
    }

        if(highScore != 0 & !tempList.Contains(highScore))
            tempList.Add(highScore);

        PlayerPrefs.SetInt("list_size", tempList.Count);
        for(int i = 0; i < tempList.Count; i++) {
            PlayerPrefs.SetInt("list_element_" + i, tempList[i]);
        }
    }

}
