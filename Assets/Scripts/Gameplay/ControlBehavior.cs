using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBehavior : MonoBehaviour
{
    //Initializes the variables needed for controling the buttons
    [SerializeField]
    private BulletShooterBehavior _bullet;
    [SerializeField]
    private Transform _cannonAngle;
    [SerializeField]
    private ControllControllerBehavior _tracker;
    private float _xRotation = 1;
    public static float Score;

    /// <summary>
    /// Sets all of the tracker values to 0
    /// </summary>
    private void Start()
    {
        _tracker.PowerTracker = 0;
        _tracker.RotationTracker = 0;
        _tracker.ScoreTracker = 0;
    }

    /// <summary>
    /// Sets 
    /// </summary>
    private void Update()
    {
        _tracker.ScoreTracker = Score;
    }

    public void PowerUp()
    {
        if (_tracker.PowerTracker >= 10)
            return;
        _bullet.BulletForceMuliplyer *= 1.1f;
        _tracker.PowerTracker++;
    }

    public void PowerDown()
    {
        if (_tracker.PowerTracker <= 0)
            return;
        _bullet.BulletForceMuliplyer /= 1.1f;
        _tracker.PowerTracker--;
    }

    public void RotationRight()
    {
        if (_tracker.RotationTracker >= 5)
            return;
        _xRotation += 5;
        _xRotation = Mathf.Clamp(_xRotation, -45, 45);
        _cannonAngle.rotation = Quaternion.Euler(-23, 0, _xRotation);
        _tracker.RotationTracker++;
    }

    public void RotationLeft()
    {
        if (_tracker.RotationTracker <= -5)
            return;
        _xRotation -= 5;
        _xRotation = Mathf.Clamp(_xRotation, -45, 45);
        _cannonAngle.rotation = Quaternion.Euler(-23, 0, _xRotation);
        _tracker.RotationTracker--;
    }

    /// <summary>
    /// End the application
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
