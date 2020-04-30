using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlights : MonoBehaviour
{

    public Light[] lights;
    public int lightNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void lightsOn()
    {
    
        lights[lightNumber].GetComponent<Light>().enabled = lights[lightNumber];

    }

}
