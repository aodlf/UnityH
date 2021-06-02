using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int num = 5;

    // Start is called before the first frame update
    void Start()
    {
        // 변수 (정보를 저장하는 기억 공간)
        // 정수형, 실수형, 문자열형, 논리형
        // int, float, string, bool
        int number = 10;
        Debug.Log(number);
        Debug.Log(num);
        num = 20;
    }

    // Update is called once per frame
    void Update()
    {     
        Debug.Log(num);
    }
}
