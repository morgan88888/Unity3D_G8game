using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnAPIstatic : MonoBehaviour
{
    //靜態
    //隨機 數學 輸入 時間

    // Start is called before the first frame update
    private void Start()
    {
        //使用靜態屬性
        //類別名稱.靜態屬性
        print(Random.value);

        print(Mathf.PI);

        //類別名稱.靜態屬性(對應方法)
        print(Mathf.Abs(-99));
        print(Random.Range(50, 150));

        Debug.Log("測試");
        Debug.LogWarning("警告!");
        Debug.LogError("危險");
    }

    // 更新事件 : 一次執行約 60 次
    //監聽玩家輸入事件、時間
    private void Update()
    {
        print(Time.time);

        //輸入.靜態屬性 - 滑鼠座標(0, 0) Vector3
        //print(Input.mousePosition);

        //輸入.靜態屬性 - 玩家是否按下空白鍵 - 傳回布林值方法
        //按下空白鍵會顯示 true
        //沒按空白鍵會顯示 false
        //print(Input.GetKeyDown("space"));
        print(Input.GetKeyDown(KeyCode.Space));
    }
}
