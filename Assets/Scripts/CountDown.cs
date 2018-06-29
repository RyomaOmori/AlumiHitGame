using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float count = 3;
    public int counter;
	void Update ()
    {
        count -= Time.deltaTime;
        counter = (int)count;
        GetComponent<Text>().text = counter.ToString();
        if (1 > counter) GetComponent<Text>().text = "";

    }
}
