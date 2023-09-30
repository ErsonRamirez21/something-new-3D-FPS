using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class displayScores : MonoBehaviour
{
    public TMP_Text rankingText;

    void Start()
    {
        int numberOfScores = PlayerPrefs.GetInt("list_size");
        Debug.Log("number of scores: " + numberOfScores);

        rankingText.text = "";

        for (int i = numberOfScores - 1; i >= 0; i--) {
            // Calculate the index in reverse order
            int reverseI = numberOfScores - i;
            // Concatenate the scores to the existing text
            rankingText.text += reverseI + "." + PlayerPrefs.GetInt("list_element_" + i) + "\n";
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
