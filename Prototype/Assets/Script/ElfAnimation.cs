using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ElfAnimation : MonoBehaviour
{
    private Animation Am;
    public TextMeshPro text;
    public int textcount;
    public string[] elftext;
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
        SwitchAm();
        SwitchText();
    }

    private void SwitchAm() {
        switch (elfstate)
        {
            case state.Stand:
                Am.Play("stand");
                break;


        }
    }
    private void SwitchText() {
       // if (SceneManager.GetActiveScene().name=="")
      //  {

       // }
        switch (textcount)
        {
            case 1:
                text.text = elftext[0];
                break;
            case 2:
                text.text = elftext[1];
                break;
            case 3:
                text.text = elftext[2];
                break;


        }
    }
}

