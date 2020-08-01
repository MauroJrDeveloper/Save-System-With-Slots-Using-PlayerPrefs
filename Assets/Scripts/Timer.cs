using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float _Game_Timer;

    public TextMeshProUGUI _Timer_Text;

    public int _Seconds;
    public int _Minutes;

    void Update()
    {

        _Game_Timer += Time.deltaTime;

        _Seconds = (int)(_Game_Timer % 60);
        _Minutes = (int)(_Game_Timer / 60) % 60;

        if (_Minutes < 10 && _Seconds < 10)
        {
            _Timer_Text.text = "0" + _Minutes + " : " + "0" + _Seconds;
        }

        if (_Minutes < 10 && _Seconds > 10)
        {
            _Timer_Text.text = "0" + _Minutes + " : " + _Seconds;
        }

        if (_Minutes > 10 && _Seconds > 10)
        {
            _Timer_Text.text = _Minutes + " : " + _Seconds;
        }

    }

}
