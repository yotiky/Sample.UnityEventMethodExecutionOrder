using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour {

    bool isActiveFirst;

    void Awake()
    {
        Debug.Log(gameObject.name + ".Awake");
    }
    void Start()
    {
        isActiveFirst = true;
        Debug.Log(gameObject.name + ".Start");
    }
    void Update()
    {
        if (isActiveFirst)
        {
            isActiveFirst = false;
            Debug.Log(gameObject.name + ".Update");
        }
    }
}
