using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Pose : MonoBehaviour
{
    public Animator anim;
    public bool isOnTrigger;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
        isOnTrigger = false;
    }

    public void ChangePose()
    {
        if (isOnTrigger)
        {
            

            anim.SetBool("Pose1", true);
        }
        
    }

}
