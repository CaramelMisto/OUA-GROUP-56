using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager{
    public class Engel_Olusturucu : MonoBehaviour
    {
        public GameObject SabitEngel;
        public GameObject HareketliEngel;

        [SerializeField] public static float engelZamani = 5f;

        private float timer;

        void Update()
        {
            timer += Time.deltaTime;

            if (timer >= engelZamani)
            {
                InstantiatePrefab();

                timer = 0f;
            }
        }

        void InstantiatePrefab()
        {
            float randomValue = Random.value;

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