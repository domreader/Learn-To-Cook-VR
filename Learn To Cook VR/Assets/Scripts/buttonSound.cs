using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{

   public AudioClip buttonNoise;

    public void playOnButtonDown() // Seperate script for button noise so that it did not conflict with different audio
    {

        GetComponent<AudioSource>().clip = buttonNoise;
        GetComponent<AudioSource>().Play();

    }
    
}
