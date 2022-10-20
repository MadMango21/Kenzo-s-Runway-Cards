using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Pose : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    public void ChangePose()
    {

        Debug.Log("Pose");
        
        anim.SetBool("Pose1", true);
    }

}
