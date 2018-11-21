using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Script4Sub script;

    bool done;
    void Update()
    {
        if (!done)
        {
            done = true;
            Debug.Log("Update");
            script.WriteLog();
            
            Debug.Log("- GameObject : non-active / Component : active");
            script.gameObject.SetActive(false);
            script.WriteLog();

            Debug.Log("- GameObject : non-active / Component : non-active");
            script.enabled = false;
            script.WriteLog();
        }
    }
}