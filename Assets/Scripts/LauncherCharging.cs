using UnityEngine;
using UnityEngine.UI;

public class LaunchCharging : MonoBehaviour
{
    public Slider chargingSlider;
    public LauncherController launcher;

    void Update()
    {
        if(launcher.isCharging)
        {
            float chargingProgress = launcher.currentLaunchForce;
            Debug.Log("Charging progress: " + chargingProgress);

            // Update the value of the charging slider
            chargingSlider.value = chargingProgress/200;
        }
        else
        {
            chargingSlider.value = 0;
        }
    }
}
