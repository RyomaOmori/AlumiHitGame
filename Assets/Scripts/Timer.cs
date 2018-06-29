using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countdown = 10.00F;
    public GameObject timeobject;
    	
	public void Update ()
    {
        float timecd = timeobject.GetComponent<CountDown>().counter;

        if (timecd < 1)
        {
            countdown -= Time.deltaTime;
            GetComponent<Text>().text = countdown.ToString("F1");
            if (0.0F > countdown) GetComponent<Text>().text = "終了";
        }
    }
}
