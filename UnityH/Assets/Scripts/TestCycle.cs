using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(1);
    }
   
    void Start()
    {
        Debug.Log(2);
    }

    void Update()
    {
        Debug.Log(3);
    }
}
