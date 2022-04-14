using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraFollowScript : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private BulletShooterBehavior _bullet;
    private BulletBehavior _bulletToFollow;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _basePosition;
    private float _refRatio;
    [SerializeField]
    private Vector3 _zoomScale = Vector3.one;
    [SerializeField]
    private Canvas _canvas;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _bulletToFollow = _bullet.getBullet();
        _camera = GetComponent<Camera>();
        _refRatio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        _basePosition = transform.position;
    }

    private void ScalePosition()
    {
        if (_referenceAspectRatio.x <= 0 || _referenceAspectRatio.y <= 0)
            return;

        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        Vector3 scalePosition = Vector3.Scale(_basePosition * (float)ratio, _zoomScale);

        transform.position = scalePosition;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (_bulletToFollow == null)
        {
            _zoomScale = Vector3.one;
            transform.position = new Vector3(5, 28, 71);
            transform.rotation = Quaternion.Euler(new Vector3(19, -180, 0));
            _bulletToFollow = _bullet.getBullet();
            _canvas.enabled = true;
        }
        else
        {
            Vector3 newPosition = _bulletToFollow.transform.position;
            newPosition.y += 20;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(new Vector3(80, -180, 0));

            _canvas.enabled = false;
        }
        //ScalePosition();
    }
}
