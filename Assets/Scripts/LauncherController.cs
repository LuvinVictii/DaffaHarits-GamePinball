using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public KeyCode launchKey = KeyCode.Space; 
    public float maxLaunchForce = 1000f; 
    public float chargeRate = 100f; 

    public float currentLaunchForce = 0f; 
    public bool isCharging = false; 
    private Rigidbody ballRigidbody; 

    void Start()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            ballRigidbody = ball.GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(launchKey))
        {
            isCharging = true;
        }

        if (Input.GetKey(launchKey) && isCharging)
        {
            // Debug.Log("Charging launcher with force: " + currentLaunchForce);

            currentLaunchForce += chargeRate * Time.deltaTime;
            currentLaunchForce = Mathf.Clamp(currentLaunchForce, 0f, maxLaunchForce);
        }

        if (Input.GetKeyUp(launchKey) && isCharging)
        {
            // Debug.Log("Release launcher");
            if (IsBallTouchingLauncher())
            {
                // Debug.Log("Launching with force: " + currentLaunchForce);
                Launch();
            }
            currentLaunchForce = 0f;
            isCharging = false;
        }
    }

    void Launch()
    {
        if (ballRigidbody != null)
        {
            float launchForce = currentLaunchForce; 
            Vector3 launchDirection = Vector3.forward;
            ballRigidbody.AddForce(launchDirection * launchForce, ForceMode.Impulse);
        }
    }

    bool IsBallTouchingLauncher()
    {
        float sphereRadius = 1.1f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, sphereRadius);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Ball"))
            {
                // Debug.Log("Ball is touching the launcher");
                return true;
            }
        }
        return false;
    }
}
