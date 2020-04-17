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


        Recipe1 = GetComponent<GameObject>();


    }

    public void nextOne()
    {

        posters[posterNumber].GetComponent<SpriteRenderer>().sprite = sprites[posterNumber];

       // currentSpriteNum = sprites.Length;

      // GameObject.Find("Bechemel_Sauce_Hints").GetComponent<SpriteRenderer>().sprite = sprites[currentSpriteNum - 1];

        Debug.Log("Image Changed");

    }
}
