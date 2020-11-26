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
            switch (times)
            {
                case 1:
                    tree.transform.GetChild(1).gameObject.SetActive(true);
                    break;
                case 2:
                    tree.transform.GetChild(2).gameObject.SetActive(true);
                    break;
                case 3:
                    tree.transform.GetChild(3).gameObject.SetActive(true);
                    break;
                case 4:
                    tree.transform.GetChild(4).gameObject.SetActive(true);
                    break;

            }
        }


    }
}
