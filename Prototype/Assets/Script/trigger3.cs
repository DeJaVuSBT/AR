using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger3 : MonoBehaviour
{
    public GameObject target,happen;
    public puzzel3 puzzle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==target)
        {
            happen.SetActive(true);
            Destroy(other.gameObject);
            puzzle.Progress(transform);
        }
    }
}
