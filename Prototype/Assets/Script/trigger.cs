using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject target;
    public GameObject Light;
    bool triggered;
    public AudioClip electricity;
    private void Update()
    {
        if (transform.parent.GetComponent<CharacterJoint>() == null)
        {
            triggered = false;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered&&other.gameObject==target)
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            transform.parent.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z - 0.21f);
            transform.parent.gameObject.AddComponent<CharacterJoint>().connectedBody = target.GetComponent<Rigidbody>();
         //   transform.parent.gameObject.transform.tag = "Untagged";
           // transform.parent.gameObject.GetComponent<CharacterJoint>().breakForce = 999;
            //stop the touch control from player
          //  transform.parent.gameObject.transform.tag = "Dragble";
            AudioSource.PlayClipAtPoint(electricity, transform.position);
            //need to add untouchble for some time otherwise player will ruin it 
            // target.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Light.SetActive(true);
            triggered = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
      //  other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
