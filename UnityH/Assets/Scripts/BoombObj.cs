using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoombObj : MonoBehaviour
{
    public int _durationHit = 3;
    public GameObject _effectBoom;
    public GameObject _effectHit;

    void OnMouseDown()
    {
        //Debug.Log(gameObject.name + "눌렀어요");
        _durationHit--;
        GameObject go = Instantiate(_effectHit, transform.position, _effectHit.transform.rotation);
        Destroy(go, 5);

        if (_durationHit <= 0)
        {
            go = Instantiate(_effectBoom, transform.position, _effectBoom.transform.rotation);
            Destroy(go, 5);
            Destroy(gameObject);
        }
    }

    //void OnMouseUp()
    //{
    //    Debug.Log(gameObject.name + "땟어요");
    //}

    //void OnMouseEnter()
    //{
    //    Debug.Log(gameObject.name + "안으로 들어왔어요");
    //}

    //void OnMouseExit()
    //{
    //    Debug.Log(gameObject.name + "밖으로 나갔어요");
    //}
}
