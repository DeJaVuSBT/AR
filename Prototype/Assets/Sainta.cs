using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sainta : MonoBehaviour
{
    public GameObject target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject== target)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<Animation>().Play("Wake"); 
        }
    }
}
