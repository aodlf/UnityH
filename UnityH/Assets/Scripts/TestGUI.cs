using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour
{
    public Texture _img;
    public float _radius;
    public Color _gizmosColor;
    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 300, 25), "안녕하세요");
        GUI.Box(new Rect(400, 0, 100, 130), _img);
        if(GUI.Button(new Rect(0, 200, 300, 25), "Click me!"))
        {
            Debug.Log("날 눌렀어");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = _gizmosColor;
        Gizmos.DrawSphere(transform.position, _radius);
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 10));
    }
}
