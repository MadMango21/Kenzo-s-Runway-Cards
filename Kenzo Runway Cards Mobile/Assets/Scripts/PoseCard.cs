using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseCard : MonoBehaviour

{
    public Animator anim;
    public Animation pose1;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

   public void Pose()
    {
        anim.Play("Pose");
    }
}
