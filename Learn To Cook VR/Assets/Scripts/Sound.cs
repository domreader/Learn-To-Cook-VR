using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    //Script for randomising the background tracks

    public AudioClip[] backgroundMusic; // Array to store audio

    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying == false) // When scene loads and there is no music playing this will run
        {
           
                GetComponent<AudioSource>().clip = backgroundMusic[Random.Range(0, backgroundMusic.Length)]; // One of the tracks is chosen from the array of songs 
                GetComponent<AudioSource>().Play(); // Audio is played
            Debug.Log(backgroundMusic);

        }
    }


   
}

