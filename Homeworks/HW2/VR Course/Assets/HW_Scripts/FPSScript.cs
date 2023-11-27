using UnityEngine;

public class FPSLogger : MonoBehaviour
{
    private int frameCount = 0;
    private float deltaTime = 0.0f;
    private float fps = 0.0f;
    private float oneSecondInterval = 1.0f;

    void Update()
    {
        // Update the frame count and the accumulated time.
        frameCount++;
        deltaTime += Time.unscaledDeltaTime;

        // Only update and log the average FPS once per second.
        if (deltaTime > oneSecondInterval)
        {
            fps = frameCount / deltaTime;
            Debug.Log("Average FPS over the last second: " + fps);
            frameCount = 0;
            deltaTime -= oneSecondInterval;
        }

        // Calculate and log current FPS every frame.
        float currentFPS = 1 / Time.unscaledDeltaTime;
        Debug.Log("Current FPS: " + currentFPS);
    }
}
