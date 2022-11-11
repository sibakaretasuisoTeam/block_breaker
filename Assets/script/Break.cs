using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{

    //アイテム出る場所(ブロックの位置)
    public GameObject block;
    //作成するアイテム
    public GameObject wide;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Sphere"){
            //ブロックの位置取得
            Vector3 itemposition = block.transform.position;
            //アイテム生成
            Instantiate (wide, itemposition, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
