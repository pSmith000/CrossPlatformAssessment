using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextBehavior : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    [SerializeField]
    private Text _powerText;
    [SerializeField]
    private Text _rotateText;
    [SerializeField]
    private Text _score;
    [SerializeField]
    private ControllControllerBehavior _tracker;
    float score;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _powerText.text = "Power: " + _tracker.PowerTracker;
        _rotateText.text = "Rotation: " + _tracker.RotationTracker;
        _score.text = "Score: " + _tracker.ScoreTracker;
    }
}
