using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{


	void Update ()
    {
        //タイトルからプレイシーンへ移行
        if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("GameScene");
	}
}
