using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlights : MonoBehaviour
{

    public Light[] lights;
    public int lightNumber;

   public void lightsOn() // Enabling the Light component
    {
    
        lights[lightNumber].GetComponent<Light>().enabled = true;

    }

    public void turnLightsOff() // Disabling the Light component
    {

        for (int i = 0; i < lights.Length; i++)
        {

            lights[i].GetComponent<Light>().enabled = false;

        }

    }
}
