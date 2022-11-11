using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//これでItemのpublicがインスペクタに表示される
#if UNITY_EDITOR
[CustomEditor(typeof(Item))]
#endif

//Itemクラスを親クラスに設定
public class Item_Wide : Item
{
    public override void SetStatus()
    {
        //ここでステータスを指定
        name = "Wide";
        effectTime = 5;
    }

    public override void Activation()
    {
        //アイテムの効果処理
        GameObject.Find("Bar").transform.localScale = new Vector3(6, 0.5f, 1);
    }

    public override void BeforeDestroy(){
        //アイテムの効果切れる時の処理
        GameObject.Find("Bar").transform.localScale = new Vector3(3, 0.5f, 1);
    }
}
