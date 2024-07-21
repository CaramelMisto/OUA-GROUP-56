using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Update()
    {

        transform.position += new Vector3(0, 0, moveSpeed * -1) * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        { 
            LoadGameOverScene();
        }
    }

    private void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
