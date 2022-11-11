using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    private GameObject scoreObject;
    ball scoreScript;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //ballスクリプトの変数を持ってくる
        scoreObject = GameObject.Find("Sphere");
        scoreScript = scoreObject.GetComponent<ball>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text ="score:"+scoreScript.pscore.ToString();
    }
}
