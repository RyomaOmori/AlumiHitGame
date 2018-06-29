using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerCounter : MonoBehaviour
{

    public GameObject GetGameObject;
	
	void Update ()
    {
        int hammercounter = GraphicsChenge.graphicschange();
        GetComponent<Text>().text = hammercounter.ToString();
    }
}
