using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timebar : MonoBehaviour
{
    Image bar;
    public float time;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Image>();
        time = 600;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            time -= Time.deltaTime;
            bar.fillAmount = time / 600;
        }
        else {

        }
    }
    public void Timebarstart()
    {
        stop = false;
    }
    public void Timebarstop()
    {
        stop = true;
    }
}
