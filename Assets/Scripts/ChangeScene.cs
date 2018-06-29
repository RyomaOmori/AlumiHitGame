using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject @object;

    void Update()
    {
        float tim = @object.GetComponent<Timer>().countdown;
        //Debug.Log(tim);
        if (tim < -2)//要変更
        {
            //プレイ画面からリザルト画面へ移行
            if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("Risalt");
        }
    }
}
