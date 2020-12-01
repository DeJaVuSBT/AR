using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int textcount;
    public string[] elftext;
    public GameObject dialog;
    public GameObject marker;
    private Touch touch;
    private void Start()
    {
        
    }
    public void StartDialog()
    {
        dialog.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        if (dialog.activeSelf) {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    textcount++;
                    
                }
            }
        }

        SwitchText();

    }
    private void SwitchText()
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
                marker.SetActive(true);
                text.text = elftext[2];
                break;
            case 4:
                text.text = elftext[3];
                break;
            case 5:
                text.text = elftext[4];
                break;
            case 6:
                PlayGame();
                break;


        }
    }
}
