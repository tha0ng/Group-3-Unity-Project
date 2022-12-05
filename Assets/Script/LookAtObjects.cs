using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LookAtObjects : MonoBehaviour
{
    public TextMeshProUGUI textOB; //text to display on screen
    public string description = "A campfire. No one is here."; //input description to tell us what to say when we interact on the object
    public bool inReach; //bool to tell for inreach


    void Start()
    {
        textOB.GetComponent<TextMeshProUGUI>().enabled = false; //get element text set to false when game start
    }

    void OnTriggerEnter(Collider other) //when collide with the object
    {
        if (other.gameObject.tag == "Reach") //if object is in reach
        {
            Debug.Log("in reach"); // check if player is in reach or not
            inReach = true; //inreach is true
            textOB.GetComponent<TextMeshProUGUI>().enabled = true; //make text component true and appear on screen
        }
    }

    void OnTriggerExit(Collider other) //when we exit viewing the object
    {
        if (other.gameObject.tag == "Reach") //object is not in our reach anymore
        {
            inReach = false; //inreach becomes false

            textOB.GetComponent<TextMeshProUGUI>().enabled = false; //turn off text
            textOB.GetComponent<TextMeshProUGUI>().text = ""; //set to say nothing
        }
    }

    void Update() //if we're in reach or we're looking at the object
    {
        if (inReach && Input.GetButtonDown("Interact")) //if we're in reach and we press down interact button
        {
            textOB.text = description.ToString(); //text will say what the description says
        }   

    }
}
