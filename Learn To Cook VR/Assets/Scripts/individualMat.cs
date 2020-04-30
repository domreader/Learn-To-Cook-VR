using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class individualMat : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject itemCollided;
    public string itemCollidedName;
    List<string> currentItems;
    GameObject itemList;
    GameObject recipeList;
    public GameObject colouredEdge;
    public Material[] itemMaterials;

    public List<GameObject> storedContacts;
    public TextMesh text;
    public TextMesh scoreText;
    bool timerStart = false;
    bool recipeCorrect;
    int numberCompleted;
    int score;

    float timer;

   void Start()
    {
        storedContacts = new List<GameObject>();
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        recipeList = GameObject.Find("PlaceMatSystem");

        itemMaterials = recipeList.GetComponent<recipeList>().itemMaterials;
        numberCompleted = recipeList.GetComponent<recipeList>().numberCompleted;
        recipeCorrect = recipeList.GetComponent<recipeList>().recipeCorrect;
        score = recipeList.GetComponent<recipeList>().score;


    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("There Is Collision");

        itemCollided = other.gameObject;
        itemCollidedName = other.gameObject.name;

        timerStart = true;

        if (itemCollidedName != null)
        {

            currentItems.Add(itemCollidedName);
            storedContacts.Add(itemCollided);

            itemList.GetComponent<itemList>().currentItems.Add(itemCollidedName);
            itemList.GetComponent<itemList>().storedContacts.Add(itemCollided);

            colouredEdge.GetComponent<Renderer>().material = itemMaterials[1];

            Debug.Log("Item " + itemCollided + " has been added.");
            Debug.Log("Item " + itemCollidedName + " has been added.");

        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("There The Collision Goes");
        if (itemCollided != null)
        {
            currentItems.Remove(itemCollidedName);
            itemList.GetComponent<itemList>().currentItems.Remove(itemCollidedName);
            itemList.GetComponent<itemList>().storedContacts.Remove(itemCollided);

            colouredEdge.GetComponent<Renderer>().material = itemMaterials[0];

            Debug.Log("Item " + itemCollided + " has been removed.");
        }

    }

    private void Update()
    {
        if (itemList.GetComponent<itemList>().storedContacts.Count == 0)
        {
            colouredEdge.GetComponent<Renderer>().material = itemMaterials[0];


           

        }

        if (timerStart == true)
        {
            timer += (Time.deltaTime);
            text.text = timer.ToString("F2");

            Debug.Log(timer);
           
            if (numberCompleted >= 3)
            {
                timer = 20;
            }


            if (numberCompleted >= 6)
            {
                timer = 40;
            }


            if (numberCompleted > 9)
            {
                timer = 60;
            }


            if (numberCompleted > 12)
            {
                timer = 80;
            }
        }

        if (recipeList.GetComponent<recipeList>().recipeCorrect == true)
        {
            timerStart = false;

            timer = 0;
            text.text = timer.ToString("F2");

            scoreText.text = score.ToString("F2");

        }

        if (timer >= 100)
        {
            Debug.Log("Too Long");
            timer = 0;

            timerStart = false;
        }


        

    }
}
