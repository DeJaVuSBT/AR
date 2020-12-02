using TMPro;
using UnityEngine;

public class ElfAnimation : MonoBehaviour
{
    private Animation Am;
    public TextMeshPro text;
    public int textcount = 0;
    public string[] elftext;
    //scene1
    public puzzel1 puzzle;
    public GameObject marker,scen1,spot,timer,next;

    public int scene=1;
    //scene2
    public GameObject marker2, scen2, spot2;

    void Start()
    {
        text.text = "hello,there";
        Am = GetComponent<Animation>();
        Am["Stand"].wrapMode = WrapMode.Loop;
        Am["Talk"].wrapMode = WrapMode.Loop;
        Am["Wave"].wrapMode = WrapMode.Loop;
        Am["Clap"].wrapMode = WrapMode.Loop;
        Am["Teleport"].wrapMode = WrapMode.Once;
    }


    // Update is called once per frame
    void Update()
    {
        if (scene == 1)
        {
            SwitchAm();
            SwitchText();
        }
        if (scene == 2)
        {
            SwitchAm2();
            SwitchText2();

        }
    }
    #region scene1
    private void SwitchAm()
    {
        if (textcount == 0)
        {
            Am.Play("Stand");
        }
        else if (textcount > 0 && textcount <= 3)
        {
            Am.Play("Talk");
        }
        else if (textcount > 3)
        {
            Am.Play("Stand");
        }
    }
    private void SwitchText()
    {
        if (puzzle.times ==1)
        {
            textcount = 4;
        }
        else if (puzzle.times==2)
        {
            textcount = 5;
        }
        else if (puzzle.times==3)
        {
            textcount = 6;
        }
        else if (puzzle.times==4)
        {
            textcount = 7;
        }

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
            case 4:
                text.text = elftext[3];
                break;
            case 5:
                text.text = elftext[4];
                break;
            case 6:
                text.text = elftext[5];
                break;
            case 7:
                text.text = elftext[6];
                break;
            case 8:
                marker.SetActive(true);
                text.text = elftext[7];
                break;
            case 9:
                marker.SetActive(false);
                
                spot.SetActive(true);
                spot.GetComponent<AudioSource>().Play();
                timer.GetComponent<Timebar>().Timebarstop();
                next.GetComponent<ElfAnimation>().scene = 2;
                scen1.SetActive(false);
                break;
        }
    }

    #endregion
    #region scene2
    private void SwitchAm2()
    {
        if (textcount == 0|| textcount == 3)
        {
            Am.Play("Stand");
        }
        else if (textcount > 0 && textcount < 3||textcount>3)
        {
            Am.Play("Talk");
        }
        
    }
    private void SwitchText2()
    {
      

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
            case 4:
                text.text = elftext[3];
                break;
            case 5:
                text.text = elftext[4];
                spot2.SetActive(true);
                spot2.GetComponent<AudioSource>().Play();
                marker2.SetActive(true);
                timer.GetComponent<Timebar>().Timebarstop();
                next.GetComponent<ElfAnimation>().scene = 3;
                scen2.SetActive(false);
                break;

        }
    }

    #endregion
}

