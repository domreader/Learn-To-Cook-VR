using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class placeMat : MonoBehaviour 
    
// This is the way that when two correct items are submitted they are checked then the result is printed
//if (itemList.GetComponent<itemList>().currentItems.Contains("Item1") && itemList.GetComponent<itemList>().currentItems.Contains("Item2"))
//{
//    Debug.Log("Result of 2 Items");
//}

// This is the way that when three correct items are submitted they are checked then the result is printed
//if (itemList.GetComponent<itemList>().currentItems.Contains("Item1") && itemList.GetComponent<itemList>().currentItems.Contains("Item2") && itemList.GetComponent<itemList>().currentItems.Contains("Item3"))
//{
//    Debug.Log("Result of 3 Items");
//}

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
    private void OnTriggerEnter(Collider collider)
    {


        if (collider == true)
        {

            itemOnMat = true;
            colouredEdge1.GetComponent<Renderer>().material = itemMaterials[1];
            colouredEdge2.GetComponent<Renderer>().material = itemMaterials[1];
            colouredEdge3.GetComponent<Renderer>().material = itemMaterials[1];

        }
    }

    private void OnTriggerExit(Collider collider)
      {

        if (collider == true)
        {

            itemOnMat = false ;
            colouredEdge1.GetComponent<Renderer>().material = itemMaterials[0];
            colouredEdge2.GetComponent<Renderer>().material = itemMaterials[0];
            colouredEdge3.GetComponent<Renderer>().material = itemMaterials[0];

        }
        
    }

    void submitButton()
    {

        recipeList.GetComponent<recipeList>().menu();


    }

}
