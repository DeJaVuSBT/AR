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
    public GameObject elf;
    private Touch touch;
    public AudioClip[] elfaudio;
    
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
                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject==elf)
                    {
                        AudioSource.PlayClipAtPoint(elfaudio[Random.Range(0, 3)], elf.transform.position);
                        elf.GetComponent<ElfAnimation>().textcount++;

                    }

                }
                if (touch.phase == TouchPhase.Moved&&Obj!=null)
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
        else if(pc) {
            Debug.Log("using pc");
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == elf&&Input.GetMouseButtonDown(0))
            {
                
                AudioSource.PlayClipAtPoint(elfaudio[Random.Range(0,3)],elf.transform .position);
            }
            else { Obj = null; }
            if (Input.GetMouseButtonDown(0)&&Obj!=null)
            {
                Obj.transform.GetComponent<Renderer>().material = selected;
            }
           
           
        }
    }
    
}
