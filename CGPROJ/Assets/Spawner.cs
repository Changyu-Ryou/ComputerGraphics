
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    //public GameObject arduino1;
    public Transform prefab;

    public void spawn()
    {
        Vector3 offset = new Vector3(Mathf.Sin(Time.time * 10), 0, 0);
        Instantiate(prefab, transform.position + offset, transform.rotation);

        //Score.score--;
    }
    void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            Vector3 offset = new Vector3(Random.Range(-5, 5), -3, Random.Range(-8, 0));
            //Mathf.Sin(Time.time * 10), Mathf.Sin(Time.time * 10), Mathf.Sin(Time.time * 10));
            Instantiate(prefab, transform.position + offset, transform.rotation);
            //delay(100);
        }
        //Score.score = 100;

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && Score.score > 0 )
        {
            //Vector3 offset = new Vector3(Mathf.Sin(Time.time * 10), 0, 0);
            //Instantiate(prefab, transform.position + offset, transform.rotation);
            spawn();
            Score.score--;

        }else if(Score.coin > 0)
        {
            spawn();
            Score.coin--;
        }

    }
}


