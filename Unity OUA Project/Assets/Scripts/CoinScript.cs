using GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    float moveSpeed;

    private void Start()
    {
        moveSpeed = Savings.savedObject.moveSpeed;
    }
    void Update()
    {
        transform.position += new Vector3(0, 0, moveSpeed * -1) * Time.deltaTime;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(transform.root.gameObject);
        }
    }*/

}