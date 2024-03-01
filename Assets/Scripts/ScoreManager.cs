using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component displaying the score

    public static int score = 0; // Current score

    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        score = 0;
        // Initialize the score UI
        UpdateScoreUI();
    }

    // Method to update the score
    public void UpdateScore(int points)
    {
        score += points; // Add points to the score
        UpdateScoreUI(); // Update the score UI
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save(); // Save PlayerPrefs data
    }

    // Method to update the score UI text
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // Update the text to display the current score
        }
    }
}
