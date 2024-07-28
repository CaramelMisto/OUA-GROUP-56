using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager{
    public class Engel_Olusturucu : MonoBehaviour
    {
        public GameObject SabitEngel;
        public GameObject HareketliEngel;
        public GameObject Coin;

        public static float engelZamani;

        private float timer;

        private int createCoin = 0;

        private void Start()
        {
            engelZamani = Savings.savedObject.engelZamani;
            InstantiatePrefab();
        }
        void Update()
        {
            timer += Time.deltaTime;

            if (timer >= engelZamani/3)
            {
                InstantiatePrefab();
                createCoin++;
                if(createCoin%3==0)
                    createCoin=0;
                timer = 0f;
            }
            
        }

        void InstantiatePrefab()
        {

            float randomValue = Random.value;
            
            if (createCoin<2)
            {
                if (randomValue < 0.25f)
                {
                    Instantiate(Coin, new Vector3(-3, 0, 50), Quaternion.identity);
                }
                else if (randomValue < 0.75f)
                {
                    Instantiate(Coin, new Vector3(0, 0, 50), Quaternion.identity);
                }
                else
                {
                    Instantiate(Coin, new Vector3(3, 0, 50), Quaternion.identity);
                }
                return;
            }

            if (randomValue < 0.2f)
            {
                Instantiate(SabitEngel, new Vector3(-3, 0, 50), Quaternion.identity);
            }
            else if (randomValue < 0.4f)
            {
                Instantiate(SabitEngel, new Vector3(0, 0, 50), Quaternion.identity);
            }
            else if (randomValue < 0.6f)
            {
                Instantiate(SabitEngel, new Vector3(3, 0, 50), Quaternion.identity);
            }
            else
            {
                Instantiate(HareketliEngel, new Vector3(0, 0, 50), Quaternion.identity);
            }
        }
    }
}