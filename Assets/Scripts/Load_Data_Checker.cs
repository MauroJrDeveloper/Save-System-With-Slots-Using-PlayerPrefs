using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Load_Data_Checker : MonoBehaviour
{

    public Transform _Ball;

    public Timer _Timer_Script;

    public Button _Slot_1;
    public Button _Slot_2;
    public Button _Slot_3;

    public TextMeshProUGUI _Slot_1_Timer;
    public TextMeshProUGUI _Slot_1_Tileset_Name;

    public TextMeshProUGUI _Slot_2_Timer;
    public TextMeshProUGUI _Slot_2_Tileset_Name;

    public TextMeshProUGUI _Slot_3_Timer;
    public TextMeshProUGUI _Slot_3_Tileset_Name;

    public int _Seconds_Slot_1;
    public int _Minutes_Slot_1;

    public int _Seconds_Slot_2;
    public int _Minutes_Slot_2;

    public int _Seconds_Slot_3;
    public int _Minutes_Slot_3;

    private void Awake()
    {

        Time.timeScale = 1;

        if(Load_Scene._Loading_Game_By_Slot_1 == true)
        {
            _Ball.transform.position = new Vector3(PlayerPrefs.GetFloat("Ball_X_Slot_1"), PlayerPrefs.GetFloat("Ball_Y_Slot_1"), PlayerPrefs.GetFloat("Ball_Z_Slot_1"));
            _Timer_Script._Game_Timer = PlayerPrefs.GetFloat("Timer_Slot_1");
            Load_Scene._Loading_Game_By_Slot_1 = false;
        }

        if (Load_Scene._Loading_Game_By_Slot_2 == true)
        {
            _Ball.transform.position = new Vector3(PlayerPrefs.GetFloat("Ball_X_Slot_2"), PlayerPrefs.GetFloat("Ball_Y_Slot_2"), PlayerPrefs.GetFloat("Ball_Z_Slot_2"));
            _Timer_Script._Game_Timer = PlayerPrefs.GetFloat("Timer_Slot_2");
            Load_Scene._Loading_Game_By_Slot_2 = false;
        }

        if (Load_Scene._Loading_Game_By_Slot_3 == true)
        {
            _Ball.transform.position = new Vector3(PlayerPrefs.GetFloat("Ball_X_Slot_3"), PlayerPrefs.GetFloat("Ball_Y_Slot_3"), PlayerPrefs.GetFloat("Ball_Z_Slot_3"));
            _Timer_Script._Game_Timer = PlayerPrefs.GetFloat("Timer_Slot_3");
            Load_Scene._Loading_Game_By_Slot_3 = false;
        }

        if (PlayerPrefs.GetInt("Save_Slot_1_Contains_Data") == 1)
        {
            _Slot_1.interactable = true;
            _Slot_1_Tileset_Name.text = PlayerPrefs.GetString("Slot_1_Tile_Set_Name");

            _Seconds_Slot_1 = (int)(PlayerPrefs.GetFloat("Timer_Slot_1") % 60);
            _Minutes_Slot_1 = (int)(PlayerPrefs.GetFloat("Timer_Slot_1") / 60) % 60;

            if (_Minutes_Slot_1 < 10 && _Seconds_Slot_1 < 10)
            {
                _Slot_1_Timer.text = "0" + _Minutes_Slot_1 + " : " + "0" + _Seconds_Slot_1;
            }

            if (_Minutes_Slot_1 < 10 && _Seconds_Slot_1 > 10)
            {
                _Slot_1_Timer.text = "0" + _Minutes_Slot_1 + " : " + _Seconds_Slot_1;
            }

            if (_Minutes_Slot_1 > 10 && _Seconds_Slot_1 > 10)
            {
                _Slot_1_Timer.text = _Minutes_Slot_1 + " : " + _Seconds_Slot_1;
            }

        }

        if (PlayerPrefs.GetInt("Save_Slot_2_Contains_Data") == 1)
        {
            _Slot_2.interactable = true;
            _Slot_2_Tileset_Name.text = PlayerPrefs.GetString("Slot_2_Tile_Set_Name");

            _Seconds_Slot_2 = (int)(PlayerPrefs.GetFloat("Timer_Slot_2") % 60);
            _Minutes_Slot_2 = (int)(PlayerPrefs.GetFloat("Timer_Slot_2") / 60) % 60;

            if (_Minutes_Slot_2 < 10 && _Seconds_Slot_2 < 10)
            {
                _Slot_2_Timer.text = "0" + _Minutes_Slot_2 + " : " + "0" + _Seconds_Slot_2;
            }

            if (_Minutes_Slot_2 < 10 && _Seconds_Slot_2 > 10)
            {
                _Slot_2_Timer.text = "0" + _Minutes_Slot_2 + " : " + _Seconds_Slot_2;
            }

            if (_Minutes_Slot_2 > 10 && _Seconds_Slot_2 > 10)
            {
                _Slot_2_Timer.text = _Minutes_Slot_2 + " : " + _Seconds_Slot_2;
            }

        }

        if (PlayerPrefs.GetInt("Save_Slot_3_Contains_Data") == 1)
        {
            _Slot_3.interactable = true;
            _Slot_3_Tileset_Name.text = PlayerPrefs.GetString("Slot_3_Tile_Set_Name");

            _Seconds_Slot_3 = (int)(PlayerPrefs.GetFloat("Timer_Slot_3") % 60);
            _Minutes_Slot_3 = (int)(PlayerPrefs.GetFloat("Timer_Slot_3") / 60) % 60;

            if (_Minutes_Slot_3 < 10 && _Seconds_Slot_3 < 10)
            {
                _Slot_3_Timer.text = "0" + _Minutes_Slot_3 + " : " + "0" + _Seconds_Slot_3;
            }

            if (_Minutes_Slot_3 < 10 && _Seconds_Slot_3 > 10)
            {
                _Slot_3_Timer.text = "0" + _Minutes_Slot_3 + " : " + _Seconds_Slot_3;
            }

            if (_Minutes_Slot_3 > 10 && _Seconds_Slot_3 > 10)
            {
                _Slot_3_Timer.text = _Minutes_Slot_3 + " : " + _Seconds_Slot_3;
            }

        }



    }

}
