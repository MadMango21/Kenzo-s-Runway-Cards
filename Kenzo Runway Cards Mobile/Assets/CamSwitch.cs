using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamSwitch : MonoBehaviour
{

    public GameObject cinematic;
    public GameObject thirdPerson;
    public GameObject firstPerson;

   
    void Start()
    {
        thirdPerson.SetActive(true);
        cinematic.SetActive(false);
    }

    public void CameraSwitch()
    {
        thirdPerson.SetActive(false);
        cinematic.SetActive(true);
    }

    
}