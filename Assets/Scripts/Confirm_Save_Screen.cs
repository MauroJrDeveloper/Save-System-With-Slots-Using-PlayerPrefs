using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirm_Save_Screen : MonoBehaviour
{

    public GameObject _Saved_Text;
    public GameObject _Confirm_Screen;
    public Save_Screen _Save_Screen_Script;

    public void Yes_Button()
    {

        if (_Save_Screen_Script._Saving_In_Slot_1 == true)
        {
            _Save_Screen_Script.Save_In_Slot_1();
            _Save_Screen_Script._Saving_In_Slot_1 = false;
            _Saved_Text.SetActive(true);
        }

        if (_Save_Screen_Script._Saving_In_Slot_2 == true)
        {
            _Save_Screen_Script.Save_In_Slot_2();
            _Save_Screen_Script._Saving_In_Slot_2 = false;
            _Saved_Text.SetActive(true);
        }

        if (_Save_Screen_Script._Saving_In_Slot_3 == true)
        {
            _Save_Screen_Script.Save_In_Slot_3();
            _Save_Screen_Script._Saving_In_Slot_3 = false;
            _Saved_Text.SetActive(true);
        }

    }

    public void No_Button()
    {
        _Save_Screen_Script._Saving_In_Slot_1 = false;
        _Save_Screen_Script._Saving_In_Slot_2 = false;
        _Save_Screen_Script._Saving_In_Slot_3 = false;
        _Confirm_Screen.SetActive(false);
    }

    public void Close_Confirm_Save_Screen()
    {
        _Confirm_Screen.SetActive(false);
    }

}
