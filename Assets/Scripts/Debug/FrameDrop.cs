using UnityEngine;

public class FrameDropDetector : MonoBehaviour
{
    public float frameRateThreshold = 60.0f;

    private float timeSinceLastFrame;

    void Update()
    {
        float frameTime = Time.deltaTime;
        float fps = 1.0f / frameTime;

        if (fps < frameRateThreshold)
        {
            Debug.Log("Frame drop detected: " + fps + " FPS");
        }

        timeSinceLastFrame = frameTime;
    }
}

