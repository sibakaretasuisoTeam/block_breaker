using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AAAAAAAAAAAA");
    }
    public Vector3 scale;
    // Update is called once per frame
    float speed = 0.04f;
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        // ���W���擾
        Vector3 pos = myTransform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (worldAngle.z < 45)
            {
                myTransform.Rotate(0f, 0f, 1f, Space.World);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (worldAngle.z > 315 || worldAngle.z == 0)
            {
                myTransform.Rotate(0f, 0f, -1f, Space.World);
            }
        }
        if(Input.GetKey(KeyCode.DownArrow) == false &&  Input.GetKey(KeyCode.UpArrow) == false){
            float x = 0;
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, x);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(pos.x < 5.3)
            pos.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(pos.x > -5.3)
            pos.x -= speed;
        }
        myTransform.position = pos;  // ���W��ݒ�
    }
     private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "item(Clone)")
            {
                Debug.Log("bbb");
                collision.gameObject.transform.localScale = new Vector3(scale.x, scale.y, scale.z);
            }
        }
}
