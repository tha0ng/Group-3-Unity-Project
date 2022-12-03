using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
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

