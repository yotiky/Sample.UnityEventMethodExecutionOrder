using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    
    IEnumerator Start()
    {
        Debug.Log("Start1");
        yield return null;
        Debug.Log("Start2");
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