using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 힘과 방향을 가지고 있는 값.
        // V(x,y)
        // V(1,2) 기준점(0,0)
        // sprt(1 x 1 + 2 x 2) = 루트5
        // 벡터합, 벡터차, 스칼라곱
        // V1(1,2) + V2(2,2) = V(3,4)
        // V1(1,2) - V2(2,2) = V(-1,0)
        // V2(2,2) - V1(1,2) = V(1,0)
        // V1(1,2) x 실수(2) = V(2,4)
        // Normalize (벡터의 정규화)
        // 벡터의 힘이 1이 되도록 하는 것.
        Vector2 v2 = new Vector2(3, 4);
        Debug.Log(v2);
        Debug.Log(v2.normalized);
        Debug.Log(v2);
        //v2.Normalize();
        //Debug.Log(v2.magnitude);
        //Debug.Log(v2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
