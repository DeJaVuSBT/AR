using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedrag : MonoBehaviour
{
    public string target;
    public Camera cam;
    public GameObject Obj=null;
    public bool pc;
    public float sens=0.001f;
    public Material selected;
    public Material normal;
    public GameObject elf1,elf2,elf3;
    private Touch touch;
    public AudioClip[] elfaudio;
    private bool isdraging = false;
    void Update()
    {
        if (!pc)
        {
            if (Input.touchCount > 0)
            {

                touch = Input.GetTouch(0);
                Vector3 pos = touch.position;
                if (touch.phase == TouchPhase.Began)
                {
                    RaycastHit hit;
                    Ray ray = cam.ScreenPointToRay(pos);

                    if (Physics.Raycast(ray, out hit) && hit.collider.tag == target)
                    {

                        Obj = hit.collider.gameObject as GameObject;

                    }
                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == elf1)
                    {

                        AudioSource.PlayClipAtPoint(elfaudio[Random.Range(0, 3)], elf1.transform.position);
                        if (elf1.GetComponent<ElfAnimation>().textcount < 3 || elf1.GetComponent<ElfAnimation>().textcount > 6)
                        {
                            elf1.GetComponent<ElfAnimation>().textcount++;
                        }



                    }
                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == elf2)
                    {
                        AudioSource.PlayClipAtPoint(elfaudio[Random.Range(0, 3)], elf2.transform.position);
                        if (elf2.GetComponent<ElfAnimation>().textcount < 3 || elf1.GetComponent<ElfAnimation>().textcount > 3)
                        {
                            elf2.GetComponent<ElfAnimation>().textcount++;
                        }
                    }
                    if (touch.phase == TouchPhase.Moved && Obj != null)
                    {
                        Obj.transform.position = new Vector3(Obj.transform.position.x + touch.deltaPosition.x * sens,
                            Obj.transform.position.y,
                            Obj.transform.position.z + touch.deltaPosition.y * sens);
                    }
                    if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                    {
                        Obj = null;
                    }
                }
            }
        }
        else if (pc)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == elf1 && Input.GetMouseButtonDown(0))
            {

                AudioSource.PlayClipAtPoint(elfaudio[Random.Range(0, 3)], elf1.transform.position);
                elf1.GetComponent<ElfAnimation>().textcount++;
            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.tag == target)
            {
                Obj = hit.collider.gameObject as GameObject;
            }
            else { Obj = null; }


            //mouse drag
            if (Input.GetMouseButtonDown(0) && Obj != null)
            {
                isdraging = true;

            }
            if (Input.GetMouseButtonUp(0))
            {
                isdraging = false;
            }
            if (isdraging)
            {
                //only X Z change in 3d 
                //   Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition)-Obj.transform.position;


                //  Obj.transform.Translate(mp);
            }


        }
    }
    
}
