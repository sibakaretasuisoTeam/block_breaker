using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//テキストを変更するための
using UnityEngine.UI;
public class time : MonoBehaviour
{
    //秒タイマー
    public float timer=0.0f;
    //テキスト
    public Text timeText;
    private GameObject sphereObject;
    ball sphereScript;
    // Start is called before the first frame update
    void Start()
    {
        sphereObject = GameObject.Find("Sphere");
        sphereScript = sphereObject.GetComponent<ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!sphereScript.start){
            timer += Time.deltaTime;
            //「Time」というの変数名やスクリプト名を別で使うとエラーになる
            //テキスト変更
                //Debug.Log(timer);
            timeText.text ="time:"+timer.ToString("f1");
        }
    }
}
