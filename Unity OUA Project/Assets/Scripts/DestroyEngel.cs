using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEngel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Engel"))
            Destroy(other.transform.root.gameObject);
    }
}
