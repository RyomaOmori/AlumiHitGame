using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changetitle : MonoBehaviour
{	
	
	void Update ()
    {
        int Count    = GraphicsChenge.graphicschange();
        
        //リザルトからからタイトルへ移行
        if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("Title");
    }
}
