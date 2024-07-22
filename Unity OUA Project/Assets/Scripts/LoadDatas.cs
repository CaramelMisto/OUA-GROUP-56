using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LoadDatas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hiScore;
    [SerializeField] private TextMeshProUGUI currScore;

    private string filePath = "GameSave.txt";

    void Start()
    {
        LoadHighScore();
    }
    public int LoadHighScore()
    {
        int currScore = 0;
        int highScore = 0;

        if (File.Exists(filePath))
        {
            string[] scoreString = File.ReadAllText(filePath).Split("\n");
            int.TryParse(scoreString[0], out currScore); 
            int.TryParse(scoreString[1], out highScore);
        }

        this.currScore.text = "Score : " + currScore; 
        hiScore.text = "HI Score : " + highScore;

        return highScore;
    }
}
