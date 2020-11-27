using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElfAnimation : MonoBehaviour
{
    private Animation Am;
    public TextMeshPro text;

    private enum state
    {
        Stand

    }
    state elfstate;
    void Start()
    {
        text.text = "hello,there";
        Am=GetComponent<Animation>();
        Am["stand"].wrapMode = WrapMode.Loop;
       
        elfstate = state.Stand;
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (elfstate)
        {
            case state.Stand:
                Am.Play("stand");
                break;


        }
    }


}

