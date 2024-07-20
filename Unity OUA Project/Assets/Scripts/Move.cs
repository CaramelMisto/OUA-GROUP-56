using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Update()
    {
        transform.position += new Vector3(0,0, moveSpeed*-1) * Time.deltaTime;
    }

}
