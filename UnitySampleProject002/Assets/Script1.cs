using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    bool isActiveFirst;
    void Awake()
    {
        Debug.Log("Awake");
    }
    void OnEnable()
    {
        isActiveFirst = true;
        Debug.Log("OnEnable");
    }
    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        if (isActiveFirst)
        {
            isActiveFirst = false;
            Debug.Log("Update");
        }
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}