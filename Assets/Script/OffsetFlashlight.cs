using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetFlashlight : MonoBehaviour //this script lets the flashlight holder that contains the flashlight follows the main camera tag (player's camera) and set a delay to the flashlight
{
    private Vector3 vectOffset;
    private GameObject goFollow;
    [SerializeField] private float speed = 3.0f;


    void Start()
    {
        goFollow = Camera.main.gameObject; //follow main camera
        vectOffset = transform.position - goFollow.transform.position;
    }




    void Update()
    {
        transform.position = goFollow.transform.position + vectOffset;
        transform.rotation = Quaternion.Slerp(transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime); //a delay in the follow movement
    }
}
