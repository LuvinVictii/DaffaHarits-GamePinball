using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera launcherCamera;
    public Collider ball;

    void Start()
    {
        mainCamera.enabled = true;
        launcherCamera.enabled = false;
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("OnTriggerEnter");
        if (collision == ball)
        {
            SwitchToLauncherCamera();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("OnTriggerExit");
        if (collision == ball)
        {
            SwitchToMainCamera();
        }
    }

    private void SwitchToLauncherCamera()
    {
        mainCamera.enabled = false;
        launcherCamera.enabled = true;
    }

    private void SwitchToMainCamera()
    {
        mainCamera.enabled = true;
        launcherCamera.enabled = false;
    }
}
