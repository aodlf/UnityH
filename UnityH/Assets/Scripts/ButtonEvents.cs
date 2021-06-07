using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    public Text _dialog;
    public Slider _slider;

    public void ChangeDialog(string txt)
    {
        _dialog.text = txt;
    }

    void NowSliderValue()
    {
        Debug.Log("S_Value" + _slider.value);
    }
}
