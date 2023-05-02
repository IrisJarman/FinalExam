using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{


    public Button SaveButton;
    public Button LoadButton;
    public Button NewGameButton;
    public Image PauseMenu;

    private bool isPaused = false;





    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        PauseMenu.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        PauseMenu.gameObject.SetActive(false);

    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
