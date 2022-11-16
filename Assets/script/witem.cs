using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witem : MonoBehaviour
{
    Rigidbody myRigidbody;
    public float ispeed = -5f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       myRigidbody.velocity = new Vector3(0f, ispeed, 0f);
    }
    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Bottom wall")
            {
                Destroy(gameObject);
            }
            if (collision.gameObject.name == "Bar")
            {
                Destroy(gameObject);
            }
        }
}
