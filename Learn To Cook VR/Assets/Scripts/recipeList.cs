﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipeList : MonoBehaviour
{
    //Initialising Variables

    public bool recipeCorrect = false;
    public bool recipeIncorrect = false;
    GameObject itemList;
    public GameObject buttonEdge;
    public Material[] itemMaterials;
    GameObject item1;
    GameObject item2;
    GameObject item3;
    float timer;
    GameObject colouredEdge;

    

    void Start()
    {

        itemList = GameObject.Find("PlaceMatSystem");

    }

    // Menu contains all of the recipes that can be completed in the game. Each checks the itemList Script and looks at current items. Depending on the names matching up it then knows the right recipe has been achieved. 
    // These recipes are not locked into the order they are shown below so they can be combined in different ways.
    public void menu()
    {
        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Milk"))
        {
            Debug.Log("Bechemel");
            recipeCorrect = true; //By setting recipe correct to true allows for further actions such as changing colours and activating timer


            item1 = itemList.GetComponent<itemList>().storedContacts[0];    //As items are being destroyed this is included on each correct recipe due to a bug where if not the new item would not be stored
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }


        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("VegStock"))
        {
            Debug.Log("Veloute");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];

        }
       

        if (itemList.GetComponent<itemList>().currentItems.Contains("BasmatiRice") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("ChickenStock"))
        {
            Debug.Log("Risotto");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if(itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Yoghurt") && itemList.GetComponent<itemList>().currentItems.Contains("Mixed Herbs"))
        {
            Debug.Log("Easy Pizza Dough");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Brioche") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Vanilla Ice Cream"))
        {
            Debug.Log("Easy Vanilla French Toast");
            recipeCorrect = true;
            
            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];

        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Chicken Wings") && itemList.GetComponent<itemList>().currentItems.Contains("Gochujang") && itemList.GetComponent<itemList>().currentItems.Contains("Spring Onions"))
        {
            Debug.Log("Korean Style Wings");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }
        
        if (itemList.GetComponent<itemList>().currentItems.Contains("Filo Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Mozarella") && itemList.GetComponent<itemList>().currentItems.Contains("Bacon"))
        {
            Debug.Log("Bacon & Mozarella Sticks");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Coconut Milk") && itemList.GetComponent<itemList>().currentItems.Contains("Condensed Milk") && itemList.GetComponent<itemList>().currentItems.Contains("Cocoa Powder"))
        {
            Debug.Log("Easy Fudge Pops");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Puff Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Bacon") && itemList.GetComponent<itemList>().currentItems.Contains("Egg Yolks"))
        {
            Debug.Log("Bacon Turnovers");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Puff Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Sausages") && itemList.GetComponent<itemList>().currentItems.Contains("Egg Yolks"))
        {
            Debug.Log("Sausage Rolls");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Chicken Wings") && itemList.GetComponent<itemList>().currentItems.Contains("Garlic") && itemList.GetComponent<itemList>().currentItems.Contains("Mixed Herbs"))
        {
            Debug.Log("Garlic & Herb Wings");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Egg Whites") && itemList.GetComponent<itemList>().currentItems.Contains("Caster Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Strawberries"))
        {
            Debug.Log("Strawbery Meringues");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Egg Whites") && itemList.GetComponent<itemList>().currentItems.Contains("Caster Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Lemon"))
        {
            Debug.Log("Lemon Meringues");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }
        
        if (itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Light Muscavado Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Condensed Milk"))
        {
            Debug.Log("Easy Caramel");
            recipeCorrect = true;

            item1 = itemList.GetComponent<itemList>().storedContacts[0];
            item2 = itemList.GetComponent<itemList>().storedContacts[0 + 1];
            item3 = itemList.GetComponent<itemList>().storedContacts[0 + 2];
        }
    }
    
     void Update()
     {


        if (recipeCorrect == true) //As mentioned above when the recipe is marked as correct the timer is started as well as the button edge being changed to green to show off that it was the correct answer
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            buttonEdge.GetComponent<Renderer>().material = itemMaterials[2]; //Changing colour of button edge to green

        }

        if (timer > 5) //Upon the timer being greater than 5 the items are destroyed
        {

            Destroy(item1);
            Destroy(item2);
            Destroy(item3);

            itemList.GetComponent<itemList>().storedContacts.Clear(); // THe stored contacts list is cleared to allow for repopulation of fields

            buttonEdge.GetComponent<Renderer>().material = itemMaterials[0]; //Button edge set back to placeholder colour
            
            recipeCorrect = false;

            timer = 0; 
        }


     }

}
