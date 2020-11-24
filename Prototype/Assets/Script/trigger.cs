using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject target;
    bool triggered;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!triggered&&other.gameObject==target)
        {
            other.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.21f);
            transform.parent.gameObject.AddComponent<CharacterJoint>().connectedBody = target.GetComponent<Rigidbody>();
            target.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            triggered = true;
        }
    }
}
