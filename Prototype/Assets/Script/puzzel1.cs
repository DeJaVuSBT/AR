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
            Debug.Log("triggerd");
            GameObject go = collision.gameObject as GameObject;
            Destroy(go);
            times++;
            string itemname = collision.gameObject.name;
            if (itemname == "Tree1")
            {

                tree.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (itemname == "Tree2")
            {
                tree.transform.GetChild(2).gameObject.SetActive(true);
            }
            else if (itemname == "Tree3")
            {
                tree.transform.GetChild(3).gameObject.SetActive(true);
            }
            else if (itemname == "TreeStar")
            {
                tree.transform.GetChild(4).gameObject.SetActive(true);
            }
                
            
        }


    }
}
