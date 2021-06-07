using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTestScript : MonoBehaviour
{    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("마우스 좌클릭 했어요");
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rHit;
            int LMask = 1 << LayerMask.NameToLayer("Floor") | 1 << LayerMask.NameToLayer("Wall");
            if(Physics.Raycast(r, out rHit, Mathf.Infinity, LMask))
            {
                Debug.Log(rHit.transform.name);
                Debug.Log(rHit.point);
            }
        }
    }
}
