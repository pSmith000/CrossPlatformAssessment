using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraFollowScript : MonoBehaviour
{
    //Serializes all the variables needed for the camera to follow the bullet when it is fired
    private Camera _camera;
    [SerializeField]
    private BulletShooterBehavior _bullet;
    private BulletBehavior _bulletToFollow;
    [SerializeField]
    private Canvas _canvas;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the camera and bullet from reference
        _camera = GetComponent<Camera>();
        _bulletToFollow = _bullet.getBullet();
    }

    // Update is called once per frame
    void Update()
    {
        //if there is no bullet
        if (_bulletToFollow == null)
        {
            //set the camera back to its original position and rotation
            transform.position = new Vector3(5, 28, 71);
            transform.rotation = Quaternion.Euler(new Vector3(19, -180, 0));
            _bulletToFollow = _bullet.getBullet();
            //Enables the ui elements
            _canvas.enabled = true;
        }
        //If there is a bullet
        else
        {
            //Sets a new position above the bullet and follows it until it is destroyed
            Vector3 newPosition = _bulletToFollow.transform.position;
            newPosition.y += 20;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(new Vector3(80, -180, 0));
            //Disables the ui elements
            _canvas.enabled = false;
        }
    }
}
