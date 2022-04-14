using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    [SerializeField]
    private bool onHitDestroy;


    private void OnTriggerEnter(Collider other)
    {
        if (onHitDestroy)
            Destroy(gameObject);
    }
}
