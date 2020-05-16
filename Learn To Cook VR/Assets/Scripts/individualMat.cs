using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
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
    bool timerStart = false;
    bool recipeCorrect;
    int numberCompleted;
    bool numberComplete = false;
    int score;
    Text scoreText;

    string fullComplete;
    int fullCompleteNum;

    float timer = 100;

   void Start()
    {

        storedContacts = new List<GameObject>();
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        recipeList = GameObject.Find("PlaceMatSystem");

        itemMaterials = recipeList.GetComponent<recipeList>().itemMaterials;
        recipeCorrect = recipeList.GetComponent<recipeList>().recipeCorrect;
        score = recipeList.GetComponent<recipeList>().score;

    }

    
    void OnTriggerEnter(Collider other) // If the item collides with the mat the edges are set to pink(item present)
    {
        Debug.Log("There Is Collision");

        itemCollided = other.gameObject; // Getting the collided gameobject
        itemCollidedName = other.gameObject.name; // Getting the name of the collided object

        timerStart = true; // Starting the game timer based on the first collision

        if (itemCollidedName != null) 
        {

            itemList.GetComponent<itemList>().currentItems.Add(itemCollidedName); // Adding the name to a list
            itemList.GetComponent<itemList>().storedContacts.Add(itemCollided); // Adding the gameobject to a list

            colouredEdge.GetComponent<Renderer>().material = itemMaterials[1]; // Setting the edge colour to pink

            Debug.Log("Item " + itemCollided + " has been added."); // Debug for testing
            Debug.Log("Item " + itemCollidedName + " has been added."); // Debug for testing

        }

    }

    void OnTriggerExit(Collider other)  // If the item is lifted off the mat the edges are set to white (item not present)
    {
        Debug.Log("There The Collision Goes");
        if (itemCollided != null)
        {

            itemList.GetComponent<itemList>().currentItems.Remove(itemCollidedName); // Remove the name from the list
            itemList.GetComponent<itemList>().storedContacts.Remove(itemCollided); // Remove the gameobject from the list

            colouredEdge.GetComponent<Renderer>().material = itemMaterials[0]; // Setting the edge colour to white 

            Debug.Log("Item " + itemCollided + " has been removed."); // Debug for testing
        }

    }

    private void numberCompletedAmount() // In the game completing recipes adds to a value called number complete, at different intervals the amount of time the user has is reduced.
                                         // This is shown below
    {

        if (numberComplete == true) 
        {

            numberCompleted++;

            numberComplete = false;
        }

        if (numberCompleted >= 3)
        {
            timer = 80;
            text.text = timer.ToString();
        }


        if (numberCompleted >= 6)
        {
            timer = 60; 
            text.text = timer.ToString();

        }


        if (numberCompleted >= 9)
        {
            timer = 40; 
            text.text = timer.ToString();

        }


        if (numberCompleted >= 12)
        {
            timer = 20; 
            text.text = timer.ToString();

        }

        if (numberCompleted == 14)
        {

            SceneManager.LoadScene("Menu Screen ");

            Analytics.CustomEvent(fullComplete);

            Analytics.SendEvent(fullComplete, fullCompleteNum, fullCompleteNum = 14);

        }

    }


    private void Update()
    {
        if (itemList.GetComponent<itemList>().storedContacts.Count == 0) // If there are no gameobjects in the list making sure that the coloured edge is set to white
        {

            colouredEdge.GetComponent<Renderer>().material = itemMaterials[0];

        }

        if (timerStart == true) // When the timer start bool is set to true the timer starts and the 3d text object is updated
        {

            timer -= (Time.deltaTime);
            text.text = timer.ToString("F2");

            numberComplete = true; // Setting number complete to true
        
        }

        if (recipeList.GetComponent<recipeList>().recipeCorrect == true) // If recipe correct is true stopping the timer and setting back to full time
        {
            timerStart = false;
            timer = 100;

            numberCompletedAmount(); // Calling number completed method

         //   Debug.Log(numberCompleted); //Used For Testing
         
            
        }

        if (timer < 0) // If timer gets to 0 score has a point taken away 
        {

            Debug.Log("Too Long");
            timer = 100;

            score -= 1;

            timerStart = false;

            SceneManager.LoadScene("Menu Screen");
        
        }

        
     

    }
}
