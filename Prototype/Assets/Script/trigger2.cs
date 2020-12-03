using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : MonoBehaviour
{
    public GameObject target;
    public puzzel3 puzzel;
    bool triggered=false;
    public AudioClip electricity;
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.gameObject == target)
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            transform.parent.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z - 0.21f);
            transform.parent.gameObject.AddComponent<CharacterJoint>().connectedBody = target.GetComponent<Rigidbody>();
            AudioSource.PlayClipAtPoint(electricity, transform.position);
            puzzel.progress++;
            triggered = true;
        }
    }

}
