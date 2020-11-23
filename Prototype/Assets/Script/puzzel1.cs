using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzel1 : MonoBehaviour
{
    public GameObject tree;
    private int times;
    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Dragble")
        {
            GameObject go = collision.gameObject as GameObject;
            Destroy(go);
            times++;
            if (times==3)
            {
                tree.SetActive(true);
            }
        }
    }
}
