using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{
   void OnEnable() //enable the load scene
   {
    //Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
    SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //load the sample scene, which is the main game scene
   }
}
