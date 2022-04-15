using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    //Serializes the bool to see if the target is to be destroyed on hit
    [SerializeField]
    private bool onHitDestroy;

    /// <summary>
    /// When anything collides into the target and the bool is set to true,
    /// the target will be destroyed
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (onHitDestroy)
            Destroy(gameObject);
    }
}
