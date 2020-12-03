using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sainta : MonoBehaviour
{
    public GameObject target;
    float time = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject== target)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<Animation>().Play("Wake");
            Ending();
        }
    }

    void Ending() {
        time -= Time.deltaTime;
        if (time<0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
