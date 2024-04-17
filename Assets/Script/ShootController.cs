using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private bool autoShoot = false;
    [SerializeField] private float shootCooldown = 1f;
    
    private float timeSinceLastShot = 0f;
    
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space) || autoShoot && timeSinceLastShot >= shootCooldown)
        {
            timeSinceLastShot = 0f;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
