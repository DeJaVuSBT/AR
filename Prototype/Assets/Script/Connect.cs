using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : MonoBehaviour
{
    GameObject target;
    
    void Start()
    {
        target = gameObject;
        gameObject.AddComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        
        do
        {
            if (target.gameObject.GetComponent<Rigidbody>()==null)
            {
                target.AddComponent<Rigidbody>();
            }
            
            target.GetComponent<CapsuleCollider>().radius = 0.001f;
            target.AddComponent<CapsuleCollider>().height = 0.0045f;
            target.GetComponent<CapsuleCollider>().direction =1;

            target.transform.GetChild(0).gameObject.AddComponent<CharacterJoint>().connectedBody= target.GetComponent<Rigidbody>(); 
          
            target = target.transform.GetChild(0).gameObject;
            Debug.Log(target);
        }

        while (target.transform.childCount > 0);
           
               
            
       
    }

}
