using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooterBehavior : MonoBehaviour
{
    //gets the necessary variables from the inspector
    [SerializeField]
    private BulletBehavior _bulletRef;
    [SerializeField]
    private BulletBehavior _bullet;
    [SerializeField]
    private float _bulletForce;
    [SerializeField]
    private GameObject _owner;

    //The multiplyer for the force of the bullet
    private float _bulletForceMultiplyer = 1;

    /// <summary>
    /// Property to get and set the bullets force multiplyer
    /// </summary>
    public float BulletForceMuliplyer
    {
        get { return _bulletForceMultiplyer; }
        set { _bulletForceMultiplyer = value; }
    }
        
    /// <summary>
    /// Spawns a bullet and adds an impulse force to it to simulate shooting
    /// </summary>
    public void Fire()
    {
        //If a bullet already exists don't spawn a bullet
        if (_bullet)
            return;
        //Instantiates a bullet with the owners position and rotation
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        _bullet = bullet.GetComponent<BulletBehavior>();
        _bullet.OwnerTag = _owner.tag;
        //Adds an impulse force using the forward, the force, and the multiplying force
        _bullet.Rigidbody.AddForce(transform.forward * _bulletForce * _bulletForceMultiplyer, ForceMode.Impulse);
    }

    /// <summary>
    /// Returns the current bullet
    /// </summary>
    public BulletBehavior getBullet()
    {
        if (_bullet == null)
            return null;
        return _bullet;
    }
}
