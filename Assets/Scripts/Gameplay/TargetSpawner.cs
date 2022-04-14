using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField]
    private TargetBehavior _target;
    // Start is called before the first frame update
    private TargetBehavior _currentTarget;
    

    private float randomX;
    private float randomZ;


    private void Start()
    {
        _currentTarget = Instantiate(_target, transform.position, transform.rotation);
    }

    private void Update()
    {
        randomX = Random.Range(-120, 120);
        randomZ = Random.Range(-30, -120);

        if (_currentTarget == null)
            _currentTarget = Instantiate(_target, new Vector3(randomX, transform.position.y, randomZ), transform.rotation);
    }

    
}
