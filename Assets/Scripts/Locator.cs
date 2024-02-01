using UnityEngine;

public class Locator : MonoBehaviour
{
    public GameObject locator;
    private ObjectPool _bulletPool;

    void Start() => _bulletPool = locator.GetComponent<ObjectPool>();

    void Update() => _bulletPool.GetPooledObject();
}
