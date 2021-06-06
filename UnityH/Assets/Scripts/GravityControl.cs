using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    Rigidbody _rg;
    public float _gravtyScale = 1;
    float _gravityNomal = 9.81f;
    // Start is called before the first frame update
    void Start()
    {
        _rg = GetComponent<Rigidbody>();
        _rg.mass = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // 자이로스코프의 값을 받아옴
        // Vector3 vInput = Input.acceleration;
        float gx = Input.GetAxis("Horizontal"); // -1 ~ 1;
        float gy = Input.GetAxis("Vertical");
        Vector3 g = new Vector3(gx, -1, gy);
        g.Normalize();

        Physics.gravity = g * _gravityNomal * _gravtyScale;
        // Debug.Log(Physics.gravity);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject + "와 충돌했다");
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject + "와 떨어졌다");
    }
    
    void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject + "와 충돌중이다");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject + "와 충돌을 체크했다");
    }
}
