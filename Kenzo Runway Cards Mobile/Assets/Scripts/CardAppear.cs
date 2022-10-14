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
        PoseCard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        Debug.Log(timer);

        if (timer > 10f)
        {
            timer = 0f;

            ColourCard.SetActive(true);
            PoseCard.SetActive(true);
        }
    }
}
