using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Clear : MonoBehaviour
{
  
    private GameObject scoreObject;
    ball scoreScript;
    private GameObject blockObject;
    block_clone blockScript;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //ballスクリプトの変数を持ってくる
        scoreObject = GameObject.Find("Sphere");
        blockObject = GameObject.Find("block_clone_system");
        scoreScript = scoreObject.GetComponent<ball>();
        blockScript = blockObject.GetComponent<block_clone>();
    }
    // Update is called once per frame
    void Update()
    {
        if(blockScript.block - scoreScript.pscore < 5 && blockScript.block != 0){
            SceneManager.LoadScene("GameCrear", LoadSceneMode.Single);
        }else{
            Debug.Log("あと" + (blockScript.block - scoreScript.pscore));
        }
    }
}
