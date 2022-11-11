using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//アイテムの親クラス
public class Item : MonoBehaviour
{
    public string name = "NoName";
    public float gravitySpeed = -5f;

    public virtual void Activation()
    {
        Debug.Log("Item will activate...");
    }

    public virtual void Start(){}

    public virtual void Update()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0f, gravitySpeed, 0f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Bottom wall")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.name == "Bar")
        {
            Activation();
            Debug.Log(name + " activated");
            //Destroy(this.gameObject);
        }
    }
}
