using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int coin=0;
    public static int score;
    int coinstat = 0;
    //public Text myText;
    public GameObject score1;
    

    // Start is called before the first frame update
    void Awake()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score1.GetComponent<Text>().text = score.ToString();

    }
    /*
    public int money()
    {
        if (score > 0)
            return 1;
        else
            return 0;
    }*/
}
