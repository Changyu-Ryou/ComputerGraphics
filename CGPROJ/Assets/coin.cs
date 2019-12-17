using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject Floor1;// = GameObject.Find("EventSystem");
    public GameObject Floor2;
    //public GameObject self= this.gameObject;
    //public static int coinsta = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Floor2.activeSelf == true)
        {
            GetComponent<Renderer>().enabled = true;
            this.gameObject.SetActive(true);
        }
        else if (Floor2.activeSelf == false)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Floor2.activeSelf == true)
        {
            GetComponent<Renderer>().enabled = true;
            this.gameObject.SetActive(true);
        }
        else if(Floor2.activeSelf == false)
        {
            GetComponent<Renderer>().enabled = false;
            this.gameObject.SetActive(false);
        }
    }

    
}
