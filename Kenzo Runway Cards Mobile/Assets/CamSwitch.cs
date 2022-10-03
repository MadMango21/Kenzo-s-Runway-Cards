using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam : MonoBehaviour
{

    public GameObject cameraOff;
    public GameObject cameraOn;
    public bool camOn = false;
    public int cameraNumber;


    void Start()
    {
        cameraNumber = 1;

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cameraOff.SetActive(true);
            cameraOn.SetActive(false);
        }
    }
}