using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public AudioSource Music;
    public Toggle musicTog;
    
    public void MusicToggleOnOff()
    {
        if (musicTog.isOn)
        {
            Music.Play();
        }
        else
        {
            Music.Pause();
        }
    }
}
