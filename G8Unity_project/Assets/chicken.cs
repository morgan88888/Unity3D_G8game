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
    public new string name = "G8雞";
    #endregion
     
    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public AudioSource aud; 

    public AudioClip soundBark;

    [Header("檢")]
    public Rigidbody rigCatch;


    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.name);

        if (other.name == "腿" && ani.GetCurrentAnimatorStateInfo(0).IsName("吃"))
        {
            Physics.IgnoreCollision(other, GetComponent<Collider>());

            other.GetComponent<HingeJoint>().connectedBody = rigCatch;
        }

        if (other.name == "沙" && ani.GetCurrentAnimatorStateInfo(0).IsName("吃"))
        {
            GameObject.Find("腿").GetComponent<HingeJoint>().connectedBody = null;
        }
    }

    private void Run()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("吃")) return;

        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);

        ani.SetBool("走路", v != 0);
    }
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal"); 
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }
    private void Bark()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("拍翅膀");

            aud.PlayOneShot(soundBark, 0.6f);
        }
    }
    private void Catch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("吃");
        }
    }
    private void Task()
    {

    }
}
