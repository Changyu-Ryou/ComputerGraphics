using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        Score.score += 1;
        //Manager.OnMessageSend();
        GameObject.Find("__Manager").GetComponent<Manager>().OnMessageSend();       //아두이노로 돈을 내보내라는 데이터 전달

    }
}
