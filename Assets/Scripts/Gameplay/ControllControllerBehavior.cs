using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllControllerBehavior : MonoBehaviour
{
    private float _powerTracker;
    private float _rotationTracker;
    private float _scoreTracker;


    public float PowerTracker
    {
        get { return _powerTracker; }
        set { _powerTracker = value; }
    }

    public float RotationTracker
    {
        get { return _rotationTracker; }
        set { _rotationTracker = value; }
    }

    public float ScoreTracker
    {
        get { return _scoreTracker; }
        set { _scoreTracker = value; }
    }

    private void Start()
    {
        _powerTracker = 0;
        _rotationTracker = 0;
        _scoreTracker = 0;
    }

}
