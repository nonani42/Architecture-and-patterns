using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 20.0f;

    private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

    private void FixedUpdate() => _rigidbody.velocity = transform.up * speed; 

    private void OnCollisionEnter2D(Collision2D col) => gameObject.SetActive(false);
}
