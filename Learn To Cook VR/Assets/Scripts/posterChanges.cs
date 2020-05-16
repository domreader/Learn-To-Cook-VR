using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class posterChanges : MonoBehaviour
{
    public Sprite[] sprites;
    GameObject Recipe1;
    int currentSpriteNum;
    public int posterNumber;
    public GameObject[] posters;

    // Start is called before the first frame update
    public void Start()
    {




    }

    public void nextPoster()
    {

        posters[posterNumber].GetComponent<SpriteRenderer>().sprite = sprites[posterNumber];

        Debug.Log("Image Changed");

    }
}
