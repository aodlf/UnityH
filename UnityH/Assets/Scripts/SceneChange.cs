using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Start()
    {
        //SceneManager.LoadScene("TestScene");
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 200, 100), "TestScene Load!"))
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
