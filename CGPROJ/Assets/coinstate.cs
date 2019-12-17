using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinstate : MonoBehaviour
{
    //[SerializeField] private GameObject _sfMain1 = null;

    // Start is called before the first frame update
    public GameObject Floor;
    public GameObject Coin;
    //public GameObject Coin2 = GameObject.Find("Coin");

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Floor.activeSelf == true)
        {
            //Coin.gameObject.SetActive(true);//gameObject가 setActive(true) 상태일 경우
            //Coin.coinsta = 1;
            Coin.SetActive(true);
        }
        else if (Floor.activeSelf == false)
        {
            //Coin.coinsta = 0;
            Coin.SetActive(false); //setActive(false);
            //gameObject가 setActive(false) 상태일 경우
        }
    }
}
