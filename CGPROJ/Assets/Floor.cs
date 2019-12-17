using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject FloorObject;//= GameObject.FindWithTag("floor");
    public GameObject Floor123;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Floor123.activeSelf == false)
        {
            FloorObject.SetActive(false);
            //Score.coin();
            //Score.coinstat = 0;
        }
        else if (Floor123.activeSelf == true)
        {
            FloorObject.SetActive(true);
            //Score.coin();
            //Score.coinstat = 1;
        }

    }
}
