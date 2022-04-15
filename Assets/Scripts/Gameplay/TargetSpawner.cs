using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    //Serializes a reference for a target and initializes a variable for the current target
    [SerializeField]
    private TargetBehavior _target;
    private TargetBehavior _currentTarget;
    
    //Two random floats to randomize the spawning of targets
    private float randomX;
    private float randomZ;

    /// <summary>
    /// sets the current target to be a new target spawned in
    /// </summary>
    private void Start()
    {
        _currentTarget = Instantiate(_target, transform.position, transform.rotation);
    }

    /// <summary>
    /// If the current target has been destroyed spawn a new one at a random location
    /// </summary>
    private void Update()
    {
        randomX = Random.Range(-120, 120);
        randomZ = Random.Range(-30, -120);

        if (_currentTarget == null)
            _currentTarget = Instantiate(_target, new Vector3(randomX, transform.position.y, randomZ), transform.rotation);
    }
}
