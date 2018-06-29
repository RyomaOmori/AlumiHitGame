using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risalt : MonoBehaviour
{
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    public Sprite Sprite6;

    public int change1 = 10;
    public int change2 = 20;
    public int change3 = 30;
    public int change4 = 40;
    public int change5 = 50;
    public int change6 = 60;


    void Update ()
    {
        SpriteRenderer resalt = gameObject.GetComponent<SpriteRenderer>();

        int Counter = GraphicsChenge.graphicschange();

        //クリック回数に応じてリザルトに画像を表示させたい
        if (Counter > change1) resalt.sprite = Sprite1;
        if (Counter > change2) resalt.sprite = Sprite2;
        if (Counter > change3) resalt.sprite = Sprite3;
        if (Counter > change4) resalt.sprite = Sprite4;
        if (Counter > change5) resalt.sprite = Sprite5;
        if (Counter > change6) resalt.sprite = Sprite6;
    }
}
