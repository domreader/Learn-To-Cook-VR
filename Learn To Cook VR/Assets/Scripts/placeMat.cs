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
    public GameObject[] items;
    public GameObject colouredEdge;
    public static bool itemOnMat = false;
    public static bool recipeCorrect = false;
    string itemTag;
    string numberMat;
    public GameObject[] mats;
    public GameObject CE1;
    public GameObject CE2;
    public GameObject CE3;

    List<string> currentItems;
    GameObject itemList;

    private void Start()
    {
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        

    }
    private void OnTriggerEnter(Collider collider)
    {
       

        if (collider == true)
        {

            numberMat = gameObject.name;
            itemTag = collider.gameObject.tag;


            Debug.Log("Item " + itemTag + " is on " + numberMat);


            itemOnMat = true;
            colouredEdge.GetComponent<Renderer>().material = itemMaterials[1];

            if (itemTag != null)
            {
                currentItems.Add(itemTag);
                itemList.GetComponent<itemList>().currentItems.Add(itemTag);

            }

            for (int i = 0; i < itemList.GetComponent<itemList>().currentItems.Count; i++)
            {

                if (itemList.GetComponent<itemList>().currentItems.Count < 3)
                {
                    Debug.Log("There are not three items");
                }

                if (itemList.GetComponent<itemList>().currentItems.Count == 3)
                {
                    Debug.Log("list contains " + itemList.GetComponent<itemList>().currentItems[i] + " and " + itemList.GetComponent<itemList>().currentItems[i + 1] + " as well as " + itemList.GetComponent<itemList>().currentItems[i + 2]);

                }

                if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter"))
                {
                    Debug.Log("Roux");
                }

                submitButton();
            }
        }
    }

    private void OnTriggerExit(Collider collider)
      {

        if (collider == true)
        {


            if (itemTag != null)
            {
                currentItems.Remove(itemTag);
                itemList.GetComponent<itemList>().currentItems.Remove(itemTag);

                Debug.Log("Item " + itemTag + " removed from list.");
            }

            numberMat = gameObject.name;
            itemTag = collider.gameObject.tag;

            Debug.Log(itemTag + " removed from " + numberMat);

            itemOnMat = false ;
            colouredEdge.GetComponent<Renderer>().material = itemMaterials[0];

        }
        
    }

    void submitButton()
    {


        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Milk"))
        {
            Debug.Log("Bechemel");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("ChickenStock") || itemList.GetComponent<itemList>().currentItems.Contains("VegStock"))
        {
            Debug.Log("Veloute");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("BasmatiRice") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("ChickenStock"))
        {
            Debug.Log("Risotto");
            recipeCorrect = true;
            CE1.GetComponent<Renderer>().material = itemMaterials[2];
            CE2.GetComponent<Renderer>().material = itemMaterials[2];
            CE3.GetComponent<Renderer>().material = itemMaterials[2];

        }
    }

}
