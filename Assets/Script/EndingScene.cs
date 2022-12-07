using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour //this script refers to the transition at the end game by touching the knife
{
   void OnEnable() //enable the load scene
   {
    //Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
    SceneManager.LoadScene("Menu", LoadSceneMode.Single);
   }
}
