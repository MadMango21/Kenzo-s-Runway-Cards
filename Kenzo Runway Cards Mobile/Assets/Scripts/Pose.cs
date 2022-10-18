using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pose : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    public void ChangePose()
    {
        Debug.Log("Pose");
        anim.SetTrigger("Pose 1");
    }

}
