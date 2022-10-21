using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAppear : MonoBehaviour
{
   
    public GameObject ColourCard;
    public GameObject PoseCard;

    float timer = 0.0f;

    void Start()
    {
        ColourCard.SetActive(false);
        PoseCard.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > 5f)
        {
            timer = 0f;

            ColourCard.SetActive(true);
            PoseCard.SetActive(true);
        }
    }
}
