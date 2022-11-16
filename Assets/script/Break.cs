using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{

    //アイテム出る場所(ブロックの位置)
    public GameObject block;
    //作成するアイテム
    public GameObject wide;
    int shp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //hp設定
    public void sethp(int hp)
    {
        shp = hp;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            //ブロックの位置取得
            Vector3 itemposition = block.transform.position;
            //アイテム生成
            Instantiate(wide, itemposition, Quaternion.identity);
            if (shp == 1)
            {
                //ブロック破壊
                Destroy(gameObject);
            }else if(shp == 2){
                //hp変更
                shp--;            
            }
        }
    }
}
