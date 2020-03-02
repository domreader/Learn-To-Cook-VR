using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{

    bool isButterAdded = false;
    bool isFlourAdded = false;

    [SerializeField]
     GameObject Flour;
    [SerializeField]
     GameObject Butter;

    GameObject pan;
    public Sprite [] sprites;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Image").GetComponent<Image>().sprite = sprites[0];
        pan = GameObject.Find("Pan").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (pan.GetComponent<BoxCollider>().isTrigger == true)
        {
            
        }
    }

    void Roux(Collider other)
    {

        if (other.gameObject.tag == "Flour")
        {

            Debug.Log("Flour Added");
            isFlourAdded = true;
            Destroy(Flour);
            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[1];
        }

        if (other.gameObject.tag == "Butter")
        {
            Debug.Log("Butter Added");
            isButterAdded = true;
            Destroy(Butter);
            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[2];

        }

        if (isButterAdded == true && isFlourAdded == true)
        {
            Debug.Log("Congrats Moron You Can Drop Stuff In A Pan");

        }

    }
}
