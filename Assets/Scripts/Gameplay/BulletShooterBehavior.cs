using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooterBehavior : MonoBehaviour
{
    [SerializeField]
    private BulletBehavior _bulletRef;
    [SerializeField]
    private BulletBehavior _bullet;
    [SerializeField]
    private float _bulletForce;
    [SerializeField]
    private GameObject _owner;

    private float _bulletForceMultiplyer = 1;

    public float BulletForceMuliplyer
    {
        get { return _bulletForceMultiplyer; }
        set { _bulletForceMultiplyer = value; }
    }
        

    public void Fire()
    {
        if (_bullet)
            return;
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        _bullet = bullet.GetComponent<BulletBehavior>();
        _bullet.OwnerTag = _owner.tag;
        _bullet.Rigidbody.AddForce(transform.forward * _bulletForce * _bulletForceMultiplyer, ForceMode.Impulse);
    }

    public BulletBehavior getBullet()
    {
        if (_bullet == null)
            return null;
        return _bullet;
    }
}
