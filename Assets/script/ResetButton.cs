using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ball anotherScript;
    void Start()
    {
        //Sphereにアクセス,スクリプト取得
        GameObject anotherObject = GameObject.Find("Sphere");
        anotherScript = anotherObject.GetComponent<ball>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //弾の位置をリセット
    public void Reset(){
        Vector3 pos = anotherScript.Position;
        anotherScript.transform.position = pos;
        anotherScript.start = true;
        anotherScript.StartChange = new Vector3(0f, 0f, 0f);
    }
}
