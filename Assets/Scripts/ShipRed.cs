using UnityEngine;

namespace Asteroids
{
    public class ShipRed : EnemyShips
    {
        public EnemyBullet bulletPrefab;
        
        private float _distanceToShoot = 5.0f;
        
        private float _lastShotTime;
        private float _shootDelay = 2.0f;
       
        private void Update()
        {
            if (Vector2.Distance(transform.position, player.transform.position) < _distanceToShoot)
            {
                if (Time.deltaTime - _lastShotTime > _shootDelay)
                {
                    ShootAtPlayer();
                    _lastShotTime = Time.deltaTime;
                }
            }
        }
        
        private void ShootAtPlayer()
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}


