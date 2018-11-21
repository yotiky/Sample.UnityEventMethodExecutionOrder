using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4Sub : MonoBehaviour
{
    public void WriteLog()
    {
        Debug.Log("GameObject is active ? :" + gameObject.activeSelf);
        Debug.Log("Component is active ? :" + enabled);
    }
}