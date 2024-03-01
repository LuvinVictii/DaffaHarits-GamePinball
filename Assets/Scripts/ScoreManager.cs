using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component displaying the score

    private int score = 0; // Current score

    void Start()
    {
        // Initialize the score UI
        UpdateScoreUI();
    }

    // Method to update the score
    public void UpdateScore(int points)
    {
        score += points; // Add points to the score
        UpdateScoreUI(); // Update the score UI
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
