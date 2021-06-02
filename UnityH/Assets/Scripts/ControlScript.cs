using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public int _number = 13;

    void Awake()
    {
        Debug.Log("시작");
    }

    // Start is called before the first frame update
    void Start()
    {
        // 제어문
        // 반복문, 조건문, 분기문

        // 반복문
        // for, while
        /* for (int n = 1; n <= 10; n++) // n += 1)
        {
            Debug.Log("n : " + n);
        } 
        for (int n = 1; n <= 10; n += 2) // n += 1)
        {
            Debug.Log("n : " + n);
        } 
        int n = 1;
        while(n <= 10)
        {
            Debug.Log("n : " + n);
            n++;
        }
        
        // 조건문
        // if else
        for (int n = 1; n <= 10; n++)
        {
            if (n % 2 == 1)
                Debug.Log("n : " + n);
            else
                Debug.Log("*");
        } */

        // 분기문
        // switch case break
        if (_number % 5 == 0)
            Debug.Log("3의 배수입니다");
        else if (_number % 5 == 1)
            Debug.Log("3의 배수가 xxxxx");
        else if (_number % 5 == 2)
            Debug.Log("3의 배수가 yyyyy");
        else
            Debug.Log("3의 배수가 아닙니다");


        switch (_number % 3)
        {
            case 0:
                Debug.Log("3의 배수입니다");
                break;
            case 1:
            case 2:
                Debug.Log("3의 배수가 아닙니다");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
