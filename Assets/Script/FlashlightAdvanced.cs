using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //textmeshpro

public class FlashlightAdvanced : MonoBehaviour //these will appear in the editor
{
    public Light light;
    public TMP_Text text;

    public TMP_Text batteryText;

    public float lifetime = 100; //the lifetime of the flashlight is 100%

    public float batteries = 0; //amount of batteries

    public AudioSource flashON;
    public AudioSource flashOFF;

    private bool on;
    private bool off;


    void Start() //when game start
    {
        light = GetComponent<Light>();

        off = true;//flashlight is off
        light.enabled = false; //and no lights are enabled

    }



    void Update() //update flashlight
    {
        text.text = "Flashlight " + lifetime.ToString("0") + "%"; //lifetime text appear on the top left corner (Flashlight 100%)
        batteryText.text = "Batteries " + batteries.ToString(); //battery text that appears on screen

        if(Input.GetButtonDown("flashlight") && off) //toggle flashlight off
        {
            flashON.Play(); //play the sound off
            light.enabled = true;
            on = true;
            off = false;
        }

        else if (Input.GetButtonDown("flashlight") && on) //toggle flashlight on
        {
            flashOFF.Play(); //play the sound on
            light.enabled = false;
            on = false;
            off = true;
        }

        if (on) //if flashlight is turned on
        {
            lifetime -= 1 * Time.deltaTime; //the percentage of the lifetime decreases by 1 through time
        }

        if(lifetime <= 0) //if lifetime equals 0
        {
            light.enabled = false; //light is off
            on = false;
            off = true;
            lifetime = 0;
        }

        if (lifetime >= 100) //sets the condition: maximum lifetime is 100 even after reload. When reload it will always come back to 100
        {
            lifetime = 100;
        }

        if (Input.GetButtonDown("reload") && batteries >= 1) //if press reload
        {
            batteries -= 1; //decrease 1 battery
            lifetime += 50; //increase 50 to lifetime
        }

        if (Input.GetButtonDown("reload") && batteries == 0) //if both battery and lifetime equals 0, flashlight is off
        {
            return;
        }

        if(batteries <= 0) //make sure the battery number decrease to 0 and not lower
        {
            batteries = 0;
        }



    }

}
