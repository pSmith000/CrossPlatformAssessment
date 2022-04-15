using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //Initializes the variables needed for the bullet
    private string _ownerTag;
    [SerializeField]
    private bool _destroyOnHit;
    private Rigidbody _rigidbody;

    /// <summary>
    /// Property to get and set the tag of the owner
    /// </summary>
    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }

    /// <summary>
    /// Property to get the rigidbody of the bullet
    /// </summary>
    public Rigidbody Rigidbody
    {
        get { return _rigidbody; }
    }

    /// <summary>
    /// Called before the first frame to get the rigidbody of the bullet
    /// </summary>
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Called when the bullet collides with another object
    /// </summary>
    /// <param name="other">the other object</param>
    private void OnTriggerEnter(Collider other)
    {
        //if the othe object is the bullets owner, return
        if (other.CompareTag(OwnerTag))
            return;

        //Destroy the bullet if it hits the ground
        if (other.tag == "Ground")
            Destroy(gameObject);

        //if the bullet hits the target destroy the bullet and add one to the score
        if (other.tag == "Target")
        {
            Destroy(gameObject);
            ControlBehavior.Score++;
        }

        //if the bool destroy on hit is set to true for the bullet, destroy the bullet
        if (_destroyOnHit)
            Destroy(gameObject);
    }
}
