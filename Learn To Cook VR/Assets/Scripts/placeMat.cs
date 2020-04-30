using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class placeMat : MonoBehaviour 
    
// The placeMat script is in place so that when a collision is detected on a mat (3 of them) the item is added to a list that is accessed in the recipe script to see if links to a correct recipe.
// On the submit button being pressed it calls the method Menu from the recipeList script containing those recipes.

{
    public Material[] itemMaterials;
    public static bool itemOnMat = false;
    public static bool recipeCorrect = false;
    string itemTag;
    string numberMat;
    public GameObject mat1;
    public GameObject mat2;
    public GameObject mat3;

    public GameObject colouredEdge1;
    public GameObject colouredEdge2;
    public GameObject colouredEdge3;
    public GameObject buttonEdge;

    public float timer;

    bool timerStarted = false;

    GameObject item1;

    List<string> currentItems;
    GameObject itemList;
    GameObject recipeList;
    List<GameObject> storedContacts;

    private void Start()
    {
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        recipeList = GameObject.Find("PlaceMatSystem");
        

        colouredEdge1 = GameObject.Find("PlaceMatSytem");
        colouredEdge2 = GameObject.Find("PlaceMatSytem");
        colouredEdge3 = GameObject.Find("PlaceMatSytem");
        buttonEdge = GameObject.Find("PlaceMatSytem");

    }
    private void OnTriggerEnter(Collider collider) // If the item collides with the mat the edges are set to pink (item present)
    {


        if (collider == true)
        {

            itemOnMat = true;
            colouredEdge1.GetComponent<Renderer>().material = itemMaterials[1];
            colouredEdge2.GetComponent<Renderer>().material = itemMaterials[1];
            colouredEdge3.GetComponent<Renderer>().material = itemMaterials[1];


        }
    }

    private void OnTriggerExit(Collider collider) // If the item is lifted off the mat the edges are set to white (item not present)
    {

        if (collider == true)
        {

            itemOnMat = false ;
            colouredEdge1.GetComponent<Renderer>().material = itemMaterials[0];
            colouredEdge2.GetComponent<Renderer>().material = itemMaterials[0];
            colouredEdge3.GetComponent<Renderer>().material = itemMaterials[0];

        }
        
    }

    void submitButton() // Calling function from recipeList
    {
        
        recipeList.GetComponent<recipeList>().menu();


    }

   

}
