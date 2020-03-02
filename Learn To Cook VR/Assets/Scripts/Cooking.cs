using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cooking : MonoBehaviour
{

    bool isButterAdded = false;
    bool isFlourAdded = false;

    [SerializeField]
    GameObject Flour;
    [SerializeField]
    GameObject Butter;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Image").GetComponent<Image>().sprite = sprites[0];

        Debug.Log("You even listening");
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Flour")
        {
            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[1];
            Debug.Log("Flour Added");
            isFlourAdded = true;
            Destroy(Flour);

        }

        if (collider.gameObject.tag == "Butter")
        {
            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[2];
            Debug.Log("Butter Added");
            isButterAdded = true;
            Destroy(Butter);

        }

        if (isButterAdded == true && isFlourAdded == true)
        {
            Debug.Log("Congratulations ... You Can Drop Stuff In A Pan");

        }

        if(collider.gameObject.tag == "placeMat")
        {
            SceneManager.LoadScene("Menu Screen");
        }


    }
}
