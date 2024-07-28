using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

namespace GameManager{

    public class ScoreScript : MonoBehaviour
    {
        [SerializeField] float ScoreSpeed = 4;
        private int scorePoints = 0;
        [SerializeField] TextMeshProUGUI scoreTxt;
            
        void Start()
        {
            InvokeRepeating("InstantiatePrefab", 0f, 1 / ScoreSpeed);
        }

        void InstantiatePrefab()
        {
            scoreTxt.text = (scorePoints++).ToString();
            if (scorePoints >= 100 && scorePoints % 50 == 0 && Time.timeScale < 2)
            {
                Time.timeScale += 0.1f;
            }
            else if(Time.timeScale == 2 && Engel_Olusturucu.engelZamani>3.5f)
            {
                Engel_Olusturucu.engelZamani -= 0.1f;
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