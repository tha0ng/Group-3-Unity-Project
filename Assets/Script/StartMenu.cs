using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = 0;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackBtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void InstructionBtn()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

