using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllControllerBehavior : MonoBehaviour
{
    //Initializes the three variables to keep track of
    private float _powerTracker;
    private float _rotationTracker;
    private float _scoreTracker;

    /// <summary>
    /// Property to get and set the power level
    /// </summary>
    public float PowerTracker
    {
        get { return _powerTracker; }
        set { _powerTracker = value; }
    }

    /// <summary>
    /// Property to get and set the rotation level
    /// </summary>
    public float RotationTracker
    {
        get { return _rotationTracker; }
        set { _rotationTracker = value; }
    }

    /// <summary>
    /// Property to get and set the score
    /// </summary>
    public float ScoreTracker
    {
        get { return _scoreTracker; }
        set { _scoreTracker = value; }
    }

    //Sets all values to 0 on start
    private void Start()
    {
        _powerTracker = 0;
        _rotationTracker = 0;
        _scoreTracker = 0;
    }

}
