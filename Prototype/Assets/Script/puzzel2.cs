using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzel2 : MonoBehaviour
{
    public GameObject light1, light2, light3,elf;
    public AudioClip finish;
    
    private bool played=false;
    // Update is called once per frame
    void Update()
    {
        if (light1.activeSelf && light2.activeSelf && light3.activeSelf&& !played)
        {
            AudioSource.PlayClipAtPoint(finish, light2.transform.position);
            played = true;
            elf.GetComponent<ElfAnimation>().textcount = 4;
        }
    }
}
