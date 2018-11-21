using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script6 : MonoBehaviour {

    public string componentName;
    bool isActiveFirst;

    void Awake()
    {
        Debug.Log(componentName + ".Awake");
    }
    void Start()
    {
        isActiveFirst = true;
        Debug.Log(componentName + ".Start");
    }
    void Update()
    {
        if (isActiveFirst)
        {
            isActiveFirst = false;
            Debug.Log(componentName + ".Update");
        }
    }
}
