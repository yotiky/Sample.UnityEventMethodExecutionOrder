using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Script3 : MonoBehaviour
{

    IEnumerator Start()
    {
        var i = 1;
        Debug.Log("Start" + i);
        enabled = false;
        foreach (var x in Enumerable.Range(0, 3))
        {
            i++;
            Debug.Log("Start" + i);
            yield return null;
        }

        enabled = true;
        i++;
        Debug.Log("Start" + i);
    }

    int counter = 0;
    void Update()
    {
        if (counter < 3)
        {
            counter++;
            Debug.Log("Update" + counter);
        }
    }
}