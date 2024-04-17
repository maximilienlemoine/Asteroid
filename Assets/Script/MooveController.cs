using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooveController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Camera mainCamera;

    void Update()
    {
        Vector2 newPosition = transform.position;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition += Vector2.left * (speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition += Vector2.right * (speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition += Vector2.up * (speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition += Vector2.down * (speed * Time.deltaTime);
        }
        
        if (IsWithinCameraView(newPosition))
        {
            transform.position = newPosition;
        }
    }
    
    bool IsWithinCameraView(Vector2 position)
    {
        Vector2 viewportPosition = mainCamera.WorldToViewportPoint(position);
        return viewportPosition.x >= 0.015 && viewportPosition.x <= 0.985 && viewportPosition.y >= 0.025 && viewportPosition.y <= 0.97;
    }
}
