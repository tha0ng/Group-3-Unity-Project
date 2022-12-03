using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    private bool inReach; //confirm if we are in reach or not

    public GameObject pickUpText; //text to show up
    private GameObject flashlight; //reference script to the flashlight

    public AudioSource pickUpSound; //pickup sound effect

    void Start() //when game starts
    {
        inReach = false; //in reach is false
        pickUpText.SetActive(false); //no pickup text
        flashlight = GameObject.Find("flashlight"); //the flashlight find the game object or tag "flashlight"
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach") //if our reach tool becomes in contact with the object
        {
            inReach = true; //inreach is true
            pickUpText.SetActive(true); //shows text
        }

    }

    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Reach")//if we exit looking at the object
        {
            inReach = false; //inreach becomes false
            pickUpText.SetActive(false); //no more text
        }
    }




    void Update()
    {
        if(Input.GetButtonDown("Interact") && inReach) //if we are in reach and we press down interact
        {
            flashlight.GetComponent<FlashlightAdvanced>().batteries += 1; //we grab the component from flashlight and plus 1 to the batteries
            pickUpSound.Play(); //play the pickup sound
            inReach = false; //inreach becomes false
            pickUpText.SetActive(false); //remove text
            Destroy(gameObject); //destroy the object from scene
        }
        
    }
}
