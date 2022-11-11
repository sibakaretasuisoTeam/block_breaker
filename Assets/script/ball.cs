using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    //text取得
    public Text Life;
    //ボールの数
    public static int lifes = 5;
    //ボールの速度
    public float speed = 5f;
    Rigidbody myRigidbody;
    //初期位置変数
    private Vector3 initialPosition;
    //private Vector3 currentPosition;
    //別スクリプトで参照
    public bool start = true;
    //スコア変数
    public int pscore = 0;
    void Start()
    {
        //初期位置保存
        initialPosition = transform.position;
        // Rigidbodyにアクセスして変数に保持しておく
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Life.text = "Life : " + lifes;
        //スペースが押されたら
        if (Input.GetKeyDown(KeyCode.Space) && start)
        {
            start = false;
            //ランダム変数
            int rand = Random.Range(-1, 1);
            if (rand == 0)
            {
                rand = 1;
            }
            //45°から-45°のランダムの角度でスタート
            myRigidbody.velocity = new Vector3(speed * rand, speed, 0f);
        }
    }
    //下にぶつかったとき
    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Bottom wall")
            {
                transform.position = initialPosition;
                myRigidbody.velocity = new Vector3(0f, 0f, 0f);
                start = true;
                //life処理
                lifes--;
                if (lifes == 0)
                {
                    lifes = 5;
                    SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
                }
                Debug.Log(lifes);
            }
            //ブロックとぶつかったとき
            if(collision.gameObject.name == "block(Clone)"){
                pscore+=1;
                Debug.Log(pscore);
            }
        }
}
