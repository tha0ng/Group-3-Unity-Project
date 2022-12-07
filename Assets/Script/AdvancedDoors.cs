using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedDoors : MonoBehaviour //this script refers to locking and unlokcing doors
{

    public Animator door;
    public GameObject lockOB;
    public GameObject keyOB;
    public GameObject openText;
    public GameObject closeText;
    public GameObject lockedText;


    public AudioSource openSound;
    public AudioSource closeSound;
    public AudioSource lockedSound;
    public AudioSource unlockedSound;

    private bool inReach;
    private bool doorisOpen;
    private bool doorisClosed;
    public bool locked;
    public bool unlocked;





    void OnTriggerEnter(Collider other) //when player collides with the door
    {
        if (other.gameObject.tag == "Reach" && doorisClosed) //if player is in reach and door is in closed state
        {
            inReach = true; //set in reach to true
            openText.SetActive(true); //Set the text on screen : Open [E]
        }

        if (other.gameObject.tag == "Reach" && doorisOpen) //if player is in reach and door is currently open
        {
            inReach = true; //set in reach to true
            closeText.SetActive(true); //set text appear on screen: Close[E]
        }
    }

    void OnTriggerExit(Collider other) //if player is not colliding with the door
    {
        if (other.gameObject.tag == "Reach") //if player is not in reach
        {
            inReach = false; //set in reach to false
            openText.SetActive(false); //remove all texts on screen
            lockedText.SetActive(false);
            closeText.SetActive(false);
        }
    }

    void Start() //when game starts
    {
        inReach = false; //every text is set to false and every door is in closed state
        doorisClosed = true;
        doorisOpen = false;
        closeText.SetActive(false);
        openText.SetActive(false);
    }




    void Update() //locking and unlocking doors
    {
        if (lockOB.activeInHierarchy)
        {
            locked = true;
            unlocked = false;
        }

        else
        {
            unlocked = true;
            locked = false;
        }

        if (inReach && keyOB.activeInHierarchy && Input.GetButtonDown("Interact"))
        {
            unlockedSound.Play(); //play the unlocked sound
            locked = false; //disable locked state
            keyOB.SetActive(false); 
            StartCoroutine(unlockDoor()); //start opening door
        }

        if (inReach && doorisClosed && unlocked && Input.GetButtonDown("Interact"))
        {
            door.SetBool("OpenDoor", true);
            door.SetBool("CloseDoor", false);
            openText.SetActive(false);
            openSound.Play();
            doorisOpen = true;
            doorisClosed = false;
        }

        else if (inReach && doorisOpen && unlocked && Input.GetButtonDown("Interact")) 
        {
            door.SetBool("OpenDoor", false);
            door.SetBool("CloseDoor", true);
            closeText.SetActive(false);
            closeSound.Play();
            doorisClosed = true;
            doorisOpen = false;
        }

        if (inReach && locked && Input.GetButtonDown("Interact"))
        {
            openText.SetActive(false); //remove text open
            lockedText.SetActive(true); //set state to locked
            lockedSound.Play(); //play locked sound
        }

    }

    IEnumerator unlockDoor()
    {
        yield return new WaitForSeconds(.05f); //delay
        {

            unlocked = true; //door is unlocked
            lockOB.SetActive(false); //remove the locked state
        }
    }




}
