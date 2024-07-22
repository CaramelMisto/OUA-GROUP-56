using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float ScoreSpeed = 4;
    private int scorePoints = 0;
    [SerializeField] TextMeshProUGUI scoreTxt;

    private string filePath = "GameSave.txt";

    void Start()
    {
        InvokeRepeating("InstantiatePrefab", 0f, 1/ScoreSpeed);
    }

    void InstantiatePrefab()
    {
        scoreTxt.text = (scorePoints++).ToString();
    }
    void OnDestroy()
    {
        SaveHighScore();
    }
    public void SaveHighScore()
    {
        int HighScore = LoadHighScore();

        if(scorePoints > HighScore)
            HighScore = scorePoints;

        File.WriteAllText(filePath, scorePoints.ToString() + "\n" + HighScore.ToString());
    }

    public int LoadHighScore()
    {
        int highScore = 0;

        if (File.Exists(filePath))
        {
            string[] scoreString = File.ReadAllText(filePath).Split("\n");
            int.TryParse(scoreString[1], out highScore);
        }

        return highScore;
    }
}
