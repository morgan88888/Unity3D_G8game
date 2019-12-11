using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    //非靜態
    //變形、剛體、動畫、音效、燈光、攝影機
    //先定義欄為存放並設定代號
    public Transform test1;
    public Transform test2;

    private void Start()
    {
        print(test1.position);

        test1.localScale = new Vector3(10, 10, 10);

        test1.localScale = Vector3.one * 5;
    }

    private void Update()
    {
        test1.Rotate(0, 5, 0);
        test2.Translate(0, 0, 1.5f);
    }

}
