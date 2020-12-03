using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzel3 : MonoBehaviour
{
    public int progress;
    public AudioClip sound1,finish;
    public GameObject sainta, box;
    public void Progress(Transform s) {
        progress++;
        AudioSource.PlayClipAtPoint(sound1, s.position);
    }
    private void Update()
    {
        if (progress==6)
        {
            AudioSource.PlayClipAtPoint(finish,transform.position);
            box.SetActive(true);
            box.GetComponent<Rigidbody>().useGravity=true; box.GetComponent<Rigidbody>().AddForce(0,9,0);
            box.GetComponent<Rigidbody>().isKinematic = false;
            progress++;
        }
    }
}
