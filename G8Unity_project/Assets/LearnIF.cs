using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    private bool openDoor;
    private int score;

    
    private void Start()
    {
        //語法 : if (布林值) { 陳述式或演算法 }
        // () 內的布林值為true 執行 {}
        if (true)
        {
            print("測試!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(openDoor)
        {
            // if () 內的布林值為 true 執行 if {}
            print("開門");
        }
        else
        {
            // if () 內的布林值為 false 執行 else {}
            print("關門");
        }
        if (score >= 60) 
        {
            print("及格");
        }
        else if (score >= 50) 
        {
            print("可以補考");
        }
        else if (score >= 40)
        {
            print("死去");
        }
        else
        {
            print("被當惹");
        }
    }
}
