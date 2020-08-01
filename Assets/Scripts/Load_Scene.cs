using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_Scene : MonoBehaviour
{

    public static bool _Loading_Game_By_Slot_1;
    public static bool _Loading_Game_By_Slot_2;
    public static bool _Loading_Game_By_Slot_3;

    public TextMeshProUGUI _Slot_1_Timer;
    public TextMeshProUGUI _Slot_1_Tileset_Name;

    public TextMeshProUGUI _Slot_2_Timer;
    public TextMeshProUGUI _Slot_2_Tileset_Name;

    public TextMeshProUGUI _Slot_3_Timer;
    public TextMeshProUGUI _Slot_3_Tileset_Name;

    public Button _Slot_1;
    public Button _Slot_2;
    public Button _Slot_3;

    public int _Seconds_Slot_1;
    public int _Minutes_Slot_1;

    public int _Seconds_Slot_2;
    public int _Minutes_Slot_2;

    public int _Seconds_Slot_3;
    public int _Minutes_Slot_3;

    void Start()
    {

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

    public void Create_Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Slot_1()
    {
        _Loading_Game_By_Slot_1 = true;
        SceneManager.LoadScene("Game");
    }

    public void Slot_2()
    {
        _Loading_Game_By_Slot_2 = true;
        SceneManager.LoadScene("Game");
    }

    public void Slot_3()
    {
        _Loading_Game_By_Slot_3 = true;
        SceneManager.LoadScene("Game");
    }

    public void Follow_Button()
    {
        Application.OpenURL("https://www.instagram.com/mauro_developer/");
    }


}
