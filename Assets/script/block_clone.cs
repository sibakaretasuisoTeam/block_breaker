using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_clone : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject original;
  public int block;
  public List<GameObject> clone = new List<GameObject>();
  void Start()
  {
    int num = 0;
    block = 0;
    Transform myTransform = original.transform;
    Vector3 pos = myTransform.position;
    int cnt = 14, st = 1, stage = ChangeScreen.stage;
    switch (stage)
    {
      //ステージ１
      case 0:
        Destroy(original);
        st = 2;
        cnt = 11;
        for (int i = 0; i < 10; i++)
        {
          for (int j = st; j <= cnt; j++)
          {
            if ((j < 5 || j > 8) && i < 9)
            {
              clone.Add(Instantiate(original, new Vector3(pos.x + j - 0.1f * j, pos.y - i + 0.1f * i, pos.z), Quaternion.identity) as GameObject);
              block++;
              Break bre = clone[num].GetComponent<Break>();
              bre.sethp(1);
              num++;
            }
            else if (i == 9)
            {
              clone.Add(Instantiate(original, new Vector3(pos.x + j - 0.1f * j, pos.y - i + 0.1f * i, pos.z), Quaternion.identity));
              block++;
              Break bre = clone[num].GetComponent<Break>();
              bre.sethp(2);
              num++;
            }
          }
        }
        break;
      //ステージ2
      case 1:
        Destroy(original);
        st = 0;
        cnt = 15;
        for (int i = 0; i < 10; i++)
        {
          for (int j = st; j <= cnt; j += 3)
          {
            Instantiate(original, new Vector3(pos.x + j - 0.1f * j, pos.y - i + 0.1f * i, pos.z), Quaternion.identity);
            block++;
          }
        }
        break;
      //ステージ3
      case 2:
        Destroy(original);
        st = 0;
        cnt = 15;
        for (int i = 0; i < 10; i++)
        {
          for (int j = st; j <= cnt; j += 2)
          {
            Instantiate(original, new Vector3(pos.x + j - 0.1f * j, pos.y - i + 0.1f * i, pos.z), Quaternion.identity);
            block++;
          }
          if (i % 2 == 0)
          {
            st = 1;
          }
          else
          {
            st = 0;
          }
        }
        break;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
