using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Pusher : MonoBehaviour
{
    private Vector3 origin;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0, 0, Mathf.Sin(Time.time));
        GetComponent<Rigidbody>().MovePosition(origin + offset);
    }


    void Awake()
    {
        origin = GetComponent<Rigidbody>().position;
    }

}
