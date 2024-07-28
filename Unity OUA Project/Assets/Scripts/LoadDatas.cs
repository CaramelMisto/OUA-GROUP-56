using GameManager;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LoadDatas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hiScore;
    [SerializeField] private TextMeshProUGUI currScore;

    private void Awake()
    {
        LoadHighScore();
    }
     
    public void LoadHighScore()
    {
        currScore.text = "Score : " + Savings.savedObject.lastScore; 
        hiScore.text = "HI Score : " + Savings.savedObject.highScore;
    }
}
