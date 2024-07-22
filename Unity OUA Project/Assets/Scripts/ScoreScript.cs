using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float ScoreSpeed = 4;
    private long scorePoints = 0;
    [SerializeField] TextMeshProUGUI scoreTxt;
    void Start()
    {
        InvokeRepeating("InstantiatePrefab", 0f, 1/ScoreSpeed);
    }

    void InstantiatePrefab()
    {
        scoreTxt.text = (scorePoints++).ToString();
    }
}
