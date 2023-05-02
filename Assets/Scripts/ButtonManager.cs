using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public Text Lives;
    public Text Points;
    public int currentlives;
    public int currentpoints;

    public void DecreaseLives()
    {
        currentlives = int.Parse(Lives.text);
        currentlives = currentlives - 1;
        Lives.text = currentlives.ToString();
    }
    public void IncreaseLives()
    {
        currentlives = int.Parse(Lives.text);
        currentlives = currentlives + 1;
        Lives.text = currentlives.ToString();
    }
    public void DecreasePoints()
    {
        currentpoints = int.Parse(Points.text);
        currentpoints = currentpoints - 1;
        Points.text = currentpoints.ToString();
    }
    public void IncreasePoints()
    {
        currentpoints = int.Parse(Points.text);
        currentpoints = currentpoints + 1;
        Points.text = currentpoints.ToString();
    }
}
