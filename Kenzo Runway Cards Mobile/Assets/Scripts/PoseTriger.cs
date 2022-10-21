using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseTriger : MonoBehaviour
{ 
   
    void Start()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pose");
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Pose").GetComponent<Pose>().isOnTrigger = true;
            
        }
    }
}
