using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //textmeshpro system

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textOB; //text to show
    public GameObject Activator; // collider
    public string dialogue = "Dialogue"; //input in the editor what the text says

    public float timer = 2f; //timer that text appears on screen



    void Start() //game start
    {
        textOB.GetComponent<TextMeshProUGUI>().enabled = false; //text is disabled
    }

    void OnTriggerEnter(Collider other) //if player collides with the trigger
    {
        if (other.gameObject.tag == "Player") //if game object tagged "player" collides
        {
            textOB.GetComponent<TextMeshProUGUI>().enabled = true; //set text to true, text appear on screen
            textOB.text = dialogue.ToString(); //text is assigned to what is in the dialogue
            StartCoroutine(DisableText()); //make it appear on the screen for a specific amount of time
        }
    }

    IEnumerator DisableText() //disable the text on screen
    {
        yield return new WaitForSeconds(timer); //wait for the timer, which is the float timer
        textOB.GetComponent<TextMeshProUGUI>().enabled = false; //after the timer finished, turn text off
        Destroy(Activator); //then destroy the activator, this way it only play once, this can be deleted if the text is supposed to appear numerous times

    }


}
