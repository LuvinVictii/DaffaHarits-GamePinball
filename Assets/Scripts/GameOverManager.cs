using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Collider ball;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            Rigidbody ballRigidbody = collision.GetComponent<Rigidbody>();
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;

            if (audioSource != null)
            {
                audioSource.Play();
            }

            SceneManager.LoadScene("GameOver");
        }
    }
}
