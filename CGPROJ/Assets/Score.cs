using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    //public Text myText;
    public GameObject score1;

    // Start is called before the first frame update
    void Awake()
    {
        score = 30;
    }

    // Update is called once per frame
    void Update()
    {
        score1.GetComponent<Text>().text = score.ToString();
    }
}
