using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public Collider ball;
    public float multiplier;
    public AudioSource audioSource;
    private Renderer renderer;
    private Animator animator;
    public ScoreManager scoreManager;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ball)
        {
            Debug.Log("Bumper hit the ball");
            scoreManager.UpdateScore(50);
            Rigidbody ballRig = ball.GetComponent<Rigidbody>();
            Vector3 reflectedVelocity = Vector3.Reflect(ballRig.velocity, collision.contacts[0].normal);
            reflectedVelocity.y = 0f;

            ballRig.velocity = reflectedVelocity * multiplier;

            if (audioSource != null)
            {
                audioSource.Play();
            }

            animator.SetTrigger("collide");

        }
    }
}
