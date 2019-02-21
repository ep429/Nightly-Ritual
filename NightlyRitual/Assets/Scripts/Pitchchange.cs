using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitchchange : MonoBehaviour
{
    public int startingPitch = 4;
    public int timeToDecrease = 5;
    AudioSource audioSource;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        audioSource = GetComponent<AudioSource>();

        //Initialize the pitch
        audioSource.pitch = 1f;
    }

    void Update()
    {
        //While the pitch is over 0, decrease it as time passes.
        if (audioSource.pitch > 0)
        {
            audioSource.pitch -= Time.deltaTime / 100;
        }
        else
        {
            audioSource.pitch = 1;
        }
    }
}
