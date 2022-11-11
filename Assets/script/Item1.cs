using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public string name;
    public float gravitySpeed = -5f;

    public void activation()
    {
    }

    void Update()
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
            activation();
            Destroy(this.gameObject);
        }
    }
}
