using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    void Start() //when game starts
    {
        Cursor.visible = true; //set the mouse cursor to be activated
        Cursor.lockState = 0; //don't lock the mouse
    }

    public void StartGame() //when player choose "Play"
    {
        SceneManager.LoadScene("Introduction Scene"); //load the introduction scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackBtn() //if player choose back button in the instruction menu
    {
        SceneManager.LoadScene("Menu"); //load the menu screen
    }

    public void InstructionBtn() //if player choose "Instruction"
    {
        SceneManager.LoadScene("Instruction"); //load instruction scene
    }

    public void QuitGame() //if player choose "Exit"
    {
        Application.Quit(); //quit the game
    }
}

