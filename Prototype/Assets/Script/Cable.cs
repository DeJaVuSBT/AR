using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    [SerializeField]
    public GameObject part, parentObj;
    [SerializeField]
    [Range(1, 100)]
    int length = 1;
    [SerializeField]
    float partDis = 0.21f;
    [SerializeField]
    bool reset, spawn, snapF=false, snapL=false;
    void Update()
    {
        if (spawn)
        {
            CreateCable();
            spawn = false;
        }
              
    }

    // Update is called once per frame
    public void CreateCable() {
        int count = (int)(length / partDis);
        Debug.Log("11111");
        for (int i = 0; i < count; i++)
        {
            GameObject tmp;
            tmp = Instantiate(part, new Vector3(transform.position.x, transform.position.y + partDis * (i + 1), transform.position.z), Quaternion.identity,parentObj.transform);
            tmp.transform.eulerAngles = new Vector3(180, 0, 0);

            tmp.name = parentObj.transform.childCount.ToString();
            if (i == 0) {
                Destroy(tmp.GetComponent<CharacterJoint>());
                if (snapF)
                {
                    tmp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                }
            }
            else
            {
                tmp.GetComponent<CharacterJoint>().connectedBody = parentObj.transform.Find((parentObj.transform.childCount - 1).ToString()).GetComponent<Rigidbody>();
            }
        }
        if (snapL)
        {
            parentObj.transform.Find((parentObj.transform.childCount).ToString()).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
