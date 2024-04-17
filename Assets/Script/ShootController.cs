using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private bool isAutoShoot = false;
        [SerializeField] private float shootCooldown = 1f;

        private float _timeSinceLastShot = 0f;

        private void Update()
        {
            _timeSinceLastShot += Time.deltaTime;
            
            if (Input.GetKeyDown(KeyCode.A)) SetAutoShoot(!isAutoShoot);

            if (!Input.GetKeyDown(KeyCode.Space) && (!isAutoShoot || !(_timeSinceLastShot >= shootCooldown))) return;
            
            _timeSinceLastShot = 0f;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
        
        public void SetAutoShoot(bool autoShoot)
        {
            this.isAutoShoot = autoShoot;
        }
    }
}
