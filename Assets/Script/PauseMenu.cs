using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //set pause menu to false
    public GameObject pauseMenuUI;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if player press ESC
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume() //If player press resume
    {
        pauseMenuUI.SetActive(false); //remove pause menu
        Time.timeScale = 1.0f; //delay time
        GameIsPaused = false; //rerun the game
    }

    public void Pause() //if player press ESC to pause the game
    {
        pauseMenuUI.SetActive(true); //trigger pause menu
        Time.timeScale = 0.0f; //instantly
        GameIsPaused = true; //pause the game
    }
    

    public void StartMenu() //if player go back to main menu
    {
        GameIsPaused = false; //remove the paused game state
        Time.timeScale = 1.0f; //delay
        SceneManager.LoadScene(0); //load the main menu scene
    }
    

    public void Exit() //if player choose exit
    {
        Application.Quit(); //quit the game
    }
}
