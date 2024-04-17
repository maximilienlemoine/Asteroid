using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition += Vector2.up * (speed * Time.deltaTime);
        
        if (CameraManager.IsWithinCameraView(newPosition))
        {
            transform.position = newPosition;
        }
        else
        {
            Destroy(gameObject);
        }    
    }
}
