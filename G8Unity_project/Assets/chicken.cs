using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    #region
    [Header("移動速度")][Range(1, 2500)]
    public int speed = 10;
    [Header("旋轉速度"), Tooltip("雞主席的旋轉速度"), Range(1.5f, 200f)]
    public float turn = 20.5f;
    [Header("是否完成任務")]
    public bool mission;
    [Header("玩家名稱")]
    public string name = "G8雞";
    #endregion
     
    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    private void Update()
    {
        Turn();
        Run();
    }

    private void Run()
    {
        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);
    }
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal"); 
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }
    private void Bark()
    {
         
    }
    private void Catch()
    {

    }
    private void Task()
    {

    }
}
