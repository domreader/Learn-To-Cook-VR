using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   void Start()
    {
        storedContacts = new List<GameObject>();
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
        recipeList = GameObject.Find("PlaceMatSystem");

        itemMaterials = recipeList.GetComponent<recipeList>().itemMaterials;

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("There Is Collision");

        itemCollided = other.gameObject;
        itemCollidedName = other.gameObject.name;


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
    }


}
