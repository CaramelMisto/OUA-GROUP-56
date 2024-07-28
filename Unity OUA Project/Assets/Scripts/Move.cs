using GameManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float moveSpeed;

    private void Start()
    {
        moveSpeed = Savings.savedObject.moveSpeed;
    }

    void Update()
    {
        transform.position += new Vector3(0,0, moveSpeed*-1) * Time.deltaTime;
    }

}
