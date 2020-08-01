using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Screen : MonoBehaviour
{

    public bool _Saving_In_Slot_1;
    public bool _Saving_In_Slot_2;
    public bool _Saving_In_Slot_3;

    public GameObject _Save_Screen;
    public GameObject _Confirm_Screen;
    public GameObject _Saved_Text;

    public Transform _Ball;

    public Ball _Ball_Script;

    public Timer _Timer_Script;

    public void Slot_1()
    {

        if (PlayerPrefs.GetInt("Save_Slot_1_Contains_Data") == 0)
        {
            _Saved_Text.SetActive(true);
            Save_In_Slot_1();
        }
        else
        {
            _Saving_In_Slot_1 = true;
            _Confirm_Screen.SetActive(true);
        }

    }

    public void Slot_2()
    {

        if (PlayerPrefs.GetInt("Save_Slot_2_Contains_Data") == 0)
        {
            _Saved_Text.SetActive(true);
            Save_In_Slot_2();
        }
        else
        {
            _Saving_In_Slot_2 = true;
            _Confirm_Screen.SetActive(true);
        }

    }

    public void Slot_3()
    {

        if (PlayerPrefs.GetInt("Save_Slot_2_Contains_Data") == 0)
        {
            _Saved_Text.SetActive(true);
            Save_In_Slot_3();
        }
        else
        {
            _Saving_In_Slot_3 = true;
            _Confirm_Screen.SetActive(true);
        }

    }

    public void Save_In_Slot_1()
    {
        PlayerPrefs.SetFloat("Ball_X_Slot_1", _Ball.position.x);
        PlayerPrefs.SetFloat("Ball_Y_Slot_1", _Ball.position.y);
        PlayerPrefs.SetFloat("Ball_Z_Slot_1", _Ball.position.z);
        PlayerPrefs.SetFloat("Timer_Slot_1", _Timer_Script._Game_Timer);
        PlayerPrefs.SetString("Slot_1_Tile_Set_Name", _Ball_Script._Tileset_Name);
        PlayerPrefs.SetInt("Save_Slot_1_Contains_Data", 1);
    }

    public void Save_In_Slot_2()
    {
        PlayerPrefs.SetFloat("Ball_X_Slot_2", _Ball.position.x);
        PlayerPrefs.SetFloat("Ball_Y_Slot_2", _Ball.position.y);
        PlayerPrefs.SetFloat("Ball_Z_Slot_2", _Ball.position.z);
        PlayerPrefs.SetFloat("Timer_Slot_2", _Timer_Script._Game_Timer);
        PlayerPrefs.SetString("Slot_2_Tile_Set_Name", _Ball_Script._Tileset_Name);
        PlayerPrefs.SetInt("Save_Slot_2_Contains_Data", 1);
    }

    public void Save_In_Slot_3()
    {
        PlayerPrefs.SetFloat("Ball_X_Slot_3", _Ball.position.x);
        PlayerPrefs.SetFloat("Ball_Y_Slot_3", _Ball.position.y);
        PlayerPrefs.SetFloat("Ball_Z_Slot_3", _Ball.position.z);
        PlayerPrefs.SetFloat("Timer_Slot_3", _Timer_Script._Game_Timer);
        PlayerPrefs.SetString("Slot_3_Tile_Set_Name", _Ball_Script._Tileset_Name);
        PlayerPrefs.SetInt("Save_Slot_3_Contains_Data", 1);
    }

    public void Close_Save_Screen()
    {
        _Save_Screen.SetActive(false);
    }

}
