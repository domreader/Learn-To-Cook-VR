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
    public static bool recipeIncorrect = false;
    string itemTag;
    string numberMat;
    public GameObject buttonEdge;
    public GameObject mat1;
    public GameObject mat2;
    public GameObject mat3;

    float timer;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    

    List<string> currentItems;
    GameObject itemList;
    GameObject recipeList;

    public void Start()
    {

        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        recipeList = GameObject.Find("PlaceMatSystem");
        recipeCorrect = GameObject.Find("recipeCorrect").GetComponent<recipeList>();


    }
    public void OnTriggerEnter(Collider collider)
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

                if (itemList.GetComponent<itemList>().currentItems.Count == 3)
                {
                    Debug.Log("list contains " + itemList.GetComponent<itemList>().currentItems[i] + " and " + itemList.GetComponent<itemList>().currentItems[i + 1] + " as well as " + itemList.GetComponent<itemList>().currentItems[i + 2]);
                }

            }
        }
    }

    public void OnTriggerExit(Collider collider)
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

    public void submitButton()
    {
        Destroy(item1);
        Destroy(item2);
        Destroy(item3);
        recipeList.GetComponent<recipeList>().menu();


        incorrectRecipe();
        deleteOnCorrect();

    }

    public void incorrectRecipe()
    {
        if (itemList.GetComponent<itemList>().currentItems.Count < 3)
        {
            recipeIncorrect = true;
            Debug.Log("There are not three items");

        }
    }

    public void deleteOnCorrect()
    {
        if (recipeList.GetComponent<recipeList>().recipeCorrect == true)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);

        }
    }

    void Update()
    {

        if (mat1.GetComponent<places>().item != null)
        {
            item1 = mat1.GetComponent<places>().item;

        }
        if (mat2.GetComponent<places>().item != null)
        {
            item2 = mat2.GetComponent<places>().item;

        }
        if (mat3.GetComponent<places>().item != null)
        {
            item3 = mat3.GetComponent<places>().item;

        }

    }

}
