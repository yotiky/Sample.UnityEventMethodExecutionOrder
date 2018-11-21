using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script8 : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;

    bool isActiveFirst;

    void Awake()
    {
        Debug.Log(gameObject.name + ".Awake");
        Debug.Log("get name from " + obj1.name);
        Debug.Log("get name from " + obj2.name);
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
