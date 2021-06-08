using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuncherControl : MonoBehaviour
{
    public GameObject _objCannonBall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(_objCannonBall, transform.position, transform.rotation);
        }
    }
}
