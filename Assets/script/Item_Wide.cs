using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//これでEnemyのpublicがインスペクタに表示される
#if UNITY_EDITOR
[CustomEditor(typeof(Item))]
#endif

//Enemyクラスを親クラスに設定
public class Item_Wide : Item
{
    private float sTime = 0;
    private float effectTime = 5;

    public override void Activation()
    {
        base.Activation();
        sTime = Time.time;
        Debug.Log("Wide_Item activated");
    }

    public override void Update(){
        base.Update();
        if(Time.time - sTime < effectTime){
        }
        else{
            Destroy(this.gameObject);
        }
    }
}
