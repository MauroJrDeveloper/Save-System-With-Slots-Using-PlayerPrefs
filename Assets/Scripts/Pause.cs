using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public bool _Pause_Autorization;

    public GameObject _Pause_Screen;
    public GameObject _Save_Screen;

    public Transform _Ball;

    private void Start()
    {
        _Pause_Autorization = true;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (_Pause_Autorization == true)
            {
                _Pause_Autorization = false;
                _Pause_Screen.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                _Pause_Screen.SetActive(false);
                Time.timeScale = 1;
                _Pause_Autorization = true;
                _Pause_Screen.SetActive(false);
            }

        }

    }

    public void Exit_Scene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Open_Save_Screen()
    {
        _Save_Screen.SetActive(true);
    }

}
