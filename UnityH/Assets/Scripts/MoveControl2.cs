using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl2 : MonoBehaviour
{
    public float _movSpeed = 10;
    public float _rotSpeed = 150;

    void Start()
    {
        
    }

    void Update()
        
    {
        float rx = Input.GetAxisRaw("Horizontal"); 
        float mx = Input.GetAxisRaw("Horiz"); 
        float mz = Input.GetAxisRaw("Vertical"); // -1 ~ 1
        //float mx = Input.GetAxisRaw("Horizontal"); // -1 ~ 1

        //Vector3 dir = (transform.forward * mz) + (transform.right * mx);
        //dir = (dir.magnitude > 1) ? dir.normalized : dir;
        //transform.position += dir * _movSpeed * Time.deltaTime;

        //transform.position += transform.right * mx * _movSpeed * Time.deltaTime;
        //transform.position += transform.forward * mz * _movSpeed * Time.deltaTime;

        //Vector3 dir = new Vector3(mx, 0, mz);
        //dir = (dir.magnitude > 1) ? dir.normalized : dir;
        //transform.Translate(dir * _movSpeed * Time.deltaTime);

        Vector3 dir = new Vector3(mx, 0, mz);
        dir = (dir.magnitude > 1) ? dir.normalized : dir;
        transform.Rotate(Vector3.up * rx * Time.deltaTime * _rotSpeed);
        transform.Translate(dir * _movSpeed * Time.deltaTime);
        //transform.Translate(Vector3.forward * mz * Time.deltaTime * _movSpeed);
    }
}
