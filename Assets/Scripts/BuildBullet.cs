using UnityEngine;

public class BuildBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    public void Build()
    {
        PlayerBullet bullet = bulletPrefab.GetComponent<PlayerBullet>();
        bullet.speed = bulletSpeed;
    }
    
    public void BulletBuilder(Transform spawnPoint, Vector2 direction)
    {
        GameObject bulletObject = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        PlayerBullet bullet = bulletObject.GetComponent<PlayerBullet>();
        bullet.speed = bulletSpeed;
    }
}
