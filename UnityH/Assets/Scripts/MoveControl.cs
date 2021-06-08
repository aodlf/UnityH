using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float _moveSpeed = 10;
    public float _rotSpeed = 120;
    Vector3 _goalPosition;
    Quaternion _goalRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rHit;
            int LMask = 1 << LayerMask.NameToLayer("Floor");
            if(Physics.Raycast(r, out rHit, Mathf.Infinity, LMask))
            {
                _goalPosition = rHit.point;
                //transform.LookAt(_goalPosition);
                _goalRotation = Quaternion.LookRotation(_goalPosition - transform.position);
                //transform.rotation = _goalRotation;
            }
        }


        //if ((_goalPosition - transform.position).magnitude >= 0.1f)
        //    transform.position += (_goalPosition - transform.position).normalized * _moveSpeed * Time.deltaTime;
        //else
        //    transform.position = _goalPosition;

        transform.position = Vector3.MoveTowards(transform.position, _goalPosition, _moveSpeed * Time.deltaTime);
        //transform.position = Vector3.Lerp(transform.position, _goalPosition, _moveSpeed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _goalRotation, _rotSpeed * Time.deltaTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation, _goalRotation, _rotSpeed * Time.deltaTime);
    }
}
