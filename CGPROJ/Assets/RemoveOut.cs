using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOut : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
