using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowData : MonoBehaviour
{
    public Text PlayerNameDisplay;
    public Text PlayerLives;
    public Text TimeLeft;

    public float TimeRemaining;


    private void Awake()
    {
        PlayerNameDisplay.text = "Currently Playing: " + KeepData.PlayerName;
        PlayerLives.text = KeepData.PlayerLives.ToString();
        TimeLeft.text = KeepData.Timer.ToString() + " (seconds) left";
        TimeRemaining = KeepData.Timer;
    }

    void Update()
    {

        TimeRemaining -= Time.deltaTime;
        if (TimeRemaining > 0)
        {
            TimeLeft.text = TimeRemaining.ToString() + " (seconds) left";
        }
        else
        {
            TimeLeft.text = "0 (seconds) left";
        }
    }

}
