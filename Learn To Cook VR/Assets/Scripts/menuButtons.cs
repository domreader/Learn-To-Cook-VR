using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuButtons : MonoBehaviour
{
    public Sprite[] sprites;
    int currentSprite = 0;
    void cycleRight()
    {        
           GameObject.Find("Image").GetComponent<Image>().sprite = sprites[currentSprite++];
    }

    void Update()
    {
        
    }
}
