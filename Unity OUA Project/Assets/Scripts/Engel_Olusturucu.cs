using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel_Olusturucu : MonoBehaviour
{
    public GameObject SabitEngel;
    public GameObject HareketliEngel;

    [SerializeField] public float engelZamani = 5f;

    void Start()
    {
        InvokeRepeating("InstantiatePrefab", 0f, engelZamani);
    }

    void InstantiatePrefab()
    {
        float randomValue = Random.value;

        if (randomValue < 0.5f)
        {
            Instantiate(SabitEngel, new Vector3(randomValue*12-3, 0, 50), Quaternion.identity);
        }
        else
        {
            Instantiate(HareketliEngel, new Vector3(0, 0, 50), Quaternion.identity);
        }
    }
}
