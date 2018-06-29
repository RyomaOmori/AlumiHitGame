using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsChenge : MonoBehaviour
{
    public Sprite GetSprite1, GetSprite2, GetSprite3, GetSprite4, GetSprite5, GetSprite6;
    public static int counter = 0;
    public GameObject game;
    public GameObject Object;

    public int change1 = 10;
    public int change2 = 20;
    public int change3 = 30;
    public int change4 = 40;
    public int change5 = 50;
    public int change6 = 60;

    public void Start()
    {
        counter = 0;
    }

    void Update()
    {
        float countim = Object.GetComponent<CountDown>().counter;
        float timer = game.GetComponent<Timer>().countdown;
        //Debug.Log(timer);
        if (countim < 1)
        {
            if (timer > 0)
            {
                SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
                //マウス入力の取得
                if (Input.GetMouseButtonDown(0)) counter += 1;
                //クリック回数に応じて画像が変化
                if (counter >= change1) renderer.sprite = GetSprite1;
                if (counter >= change2) renderer.sprite = GetSprite2;
                if (counter >= change3) renderer.sprite = GetSprite3;
                if (counter >= change4) renderer.sprite = GetSprite4;
                if (counter >= change5) renderer.sprite = GetSprite5;
                if (counter >= change6) renderer.sprite = GetSprite6;
            }
        }
    }

    
    public static int graphicschange()
    {
        return (counter);
    }
    
}
