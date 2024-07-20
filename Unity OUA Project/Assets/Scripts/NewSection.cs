using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSection : MonoBehaviour
{
    public GameObject roadSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3(0,0, 725),Quaternion.identity);
        }
    }
}
