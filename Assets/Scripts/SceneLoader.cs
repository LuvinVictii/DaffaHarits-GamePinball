using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // Public variable to store the name of the scene

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0)) // 0 represents the left mouse button
        {
            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                PlayerPrefs.SetInt("Score", 0);
                PlayerPrefs.Save();
            }
            // Load the scene based on the sceneName variable
            SceneManager.LoadScene(sceneName);
        }

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                SceneManager.LoadScene("Credit");
            }
        }
    }
}
