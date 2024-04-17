using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooveController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

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
        
        if (CameraManager.IsWithinCameraView(newPosition))
        {
            transform.position = newPosition;
        }
    }
}
