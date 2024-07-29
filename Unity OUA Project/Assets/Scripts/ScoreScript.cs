using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

namespace GameManager{

    public class ScoreScript : MonoBehaviour
    {
        [SerializeField] float ScoreSpeed = 6;
        private int scorePoints = 0;
        private int hardnessInterval = 10;
        [SerializeField] TextMeshProUGUI scoreTxt;
            
        void Start()
        {
            InvokeRepeating("InstantiatePrefab", 0f, 1 / ScoreSpeed);
            InvokeRepeating("IncreaseHardness", hardnessInterval, hardnessInterval);
        }

        void InstantiatePrefab()
        {
            scoreTxt.text = (scorePoints++).ToString();
        }

        void IncreaseHardness()
        {
            if (Time.timeScale < 1.5)
            {
                Time.timeScale += 0.1f;
            }
            else if (Savings.savedObject.engelZamani > 3f)
            {
                Savings.savedObject.engelZamani -= 0.1f;
            }
        }

        void OnDestroy()
        {
            SaveHighScore();
            Savings.Save();
        }
        public void SaveHighScore()
        {
            if (scorePoints > Savings.savedObject.highScore)
                Savings.savedObject.highScore = scorePoints;

            Savings.savedObject.lastScore = scorePoints;
        }

    }
}