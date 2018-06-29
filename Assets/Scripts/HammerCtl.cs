using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerCtl : MonoBehaviour
{
    public int _RoatHammer = 0;

    public GameObject gameObject;
    public GameObject GetGame;

    void Update ()
    {
        float timecount = GetGame.GetComponent<CountDown>().counter;
        float time = gameObject.GetComponent<Timer>().countdown;
        //Debug.Log(time);
        if (timecount < 1)
        {
            if (time > 0)
            {
                //タップしたときハンマーが動く処理
                if (Input.GetMouseButtonUp(0))
                {
                    this._RoatHammer = -45;
                    transform.Rotate(0, 0, _RoatHammer);
                }

                if (Input.GetMouseButtonDown(0))
                {
                    // this.counter += 1;
                    this._RoatHammer = 45;
                    transform.Rotate(0, 0, _RoatHammer);
                }
            }
        }
       
        
	}
}
