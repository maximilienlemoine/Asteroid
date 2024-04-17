using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static bool IsWithinCameraView(Vector2 position)
    {
        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(position);
        return viewportPosition.x >= 0.015 && viewportPosition.x <= 0.985 && viewportPosition.y >= 0.025 && viewportPosition.y <= 0.97;
    }
}
