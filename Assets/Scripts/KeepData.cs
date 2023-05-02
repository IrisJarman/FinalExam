using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static int PlayerLives;
    public static float Timer;

    public InputField PlayerNameInput;
    public Slider TimeRem;
    public Dropdown NumLives;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
    }

    public void SetTimer()
    {
        Timer = TimeRem.value;

    }
    public void SetNumLives()
    {
        switch (NumLives.value)
        {
            case 1:
                PlayerLives = 1;
                break;
            case 2:
                PlayerLives = 2;
                break;
            case 3:
                PlayerLives = 3;
                break;
            case 4:
                PlayerLives = 4;
                break;
            case 5:
                PlayerLives = 5;
                break;
            case 6:
                PlayerLives = 6;
                break;
            case 7:
                PlayerLives = 7;
                break;
            case 8:
                PlayerLives = 8;
                break;
            case 9:
                PlayerLives = 9;
                break;
            default:
                break;

        }
    }
}
