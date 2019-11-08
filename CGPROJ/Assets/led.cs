using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
//using System.IO;

public class led : MonoBehaviour
{
    public SerialPort serial = new SerialPort("COM3", 9600);        //2341
    private bool lightState = false;
    //private SerialPort sp;
    // Start is called before the first frame update
    //public GameObject arduino;

    void Start()
    {
        serial.Open();
        serial.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (serial.IsOpen)
        {
            try
            {
                if (serial.ReadByte() == 1)
                {
                    Score.coin++;
                    //Spawner.spawn();
                }

            }
            catch (System.TimeoutException ex)
            {
               // throw;
            }
        }

       
        if (Score.score > 0)
        {
            if (serial.IsOpen == false)
            {
                serial.Open();
            }
            serial.Write("A");
            lightState = true;
            Score.score--;
        }
    }
}
