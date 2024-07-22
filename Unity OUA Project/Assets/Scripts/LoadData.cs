using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hiScore;

    private string filePath = "GameSave.txt";

    void Start()
    {
        LoadHighScore();
    }
    public int LoadHighScore()
    {
        int highScore = 0;

        if (File.Exists(filePath))
        {
            string[] scoreString = File.ReadAllText(filePath).Split("\n");
            int.TryParse(scoreString[1], out highScore);
        }

        hiScore.text = "HI Score : " + highScore;

        return highScore;
    }
}
