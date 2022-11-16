using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//アイテムの親クラス
public class Item : MonoBehaviour
{
    public string name = "NoName";
    public float effectTime = 5;
    public float gravitySpeed = -5f;
    public int status = 0; // 0:落下中 1:効果中 2:効果切れた
    private float sTime = Mathf.Infinity;

    //ステータス色々設定
    public virtual void SetStatus(){
        name = "NoName";
        effectTime = 5;
    }

    //アイテムの効果処理
    public virtual void Activation()
    {
        Debug.Log("Item will activate...");
    }

    //アイテムの効果切れる時の処理
    public virtual void BeforeDestroy(){
        Debug.Log("Item will be destroyed...");
    }

    public void Start(){
        SetStatus();
    }

    public void Update()
    {
        if(status == 0){
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, gravitySpeed, 0f);
        }
        Debug.Log(sTime);
        //効果時間が切れたら削除
        if(Time.time - sTime > effectTime){
            status = 2;
            BeforeDestroy();
            Debug.Log(name + " destroyed");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bottom wall")
        {
            if(status == 0){
                Destroy(this.gameObject);
            }
        }

        //バーに当たったら効果発動
        if (other.gameObject.name == "Bar")
        {
            status = 1;
            sTime = Time.time;
            Debug.Log(name + " activated");
            Activation();
        }
    }
}
