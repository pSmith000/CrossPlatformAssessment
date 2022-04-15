using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextBehavior : MonoBehaviour
{
    //Gets all of the text UI elements and a tracker from the inspector
    [SerializeField]
    private Text _powerText;
    [SerializeField]
    private Text _rotateText;
    [SerializeField]
    private Text _score;
    [SerializeField]
    private ControllControllerBehavior _tracker;

    // Update is called once per frame
    void Update()
    {
        //Sets the text to say what values the tracker has
        _powerText.text = "Power: " + _tracker.PowerTracker;
        _rotateText.text = "Rotation: " + _tracker.RotationTracker;
        _score.text = "Score: " + _tracker.ScoreTracker;
    }
}
