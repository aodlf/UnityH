using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float _addForce = 1000;
    Rigidbody _rgbd3D;

    void Start()
    {
        _rgbd3D = GetComponent<Rigidbody>();
        _rgbd3D.AddForce(transform.forward * _addForce);
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
