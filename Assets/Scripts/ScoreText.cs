using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // Retrieve the score and display it on the text object
        int scoreGet = PlayerPrefs.GetInt("Score");
        scoreText.text = "Score: " + scoreGet.ToString();
    }
}
