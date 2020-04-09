using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipeList : MonoBehaviour
{
    GameObject itemList;
    public bool recipeCorrect = false;
    public static bool recipeIncorrect = false;
    public GameObject buttonEdge;
    public Material[] itemMaterials;
    


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


    public List<string> currentItems;
    float timer;

    public void Start()
    {
        currentItems = new List<string>();
        itemList = GameObject.Find("PlaceMatSystem");
    }

    public void menu()
    {

        
        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Milk"))
        {
            Debug.Log("Bechemel Sauce");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Veg Stock"))
        {
            Debug.Log("Veloute");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Risotto Rice") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Chicken Stock"))
        {
            Debug.Log("Risotto");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Flour") && itemList.GetComponent<itemList>().currentItems.Contains("Yoghurt") && itemList.GetComponent<itemList>().currentItems.Contains("Mixed Herbs"))
        {
            Debug.Log("Pizza Dough");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Brioche") && itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Vanilla Ice Cream"))
        {
            Debug.Log("Vanilla French Toast");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Chicken Wings") && itemList.GetComponent<itemList>().currentItems.Contains("Gochujang") && itemList.GetComponent<itemList>().currentItems.Contains("Spring Onions"))
        {
            Debug.Log("Korean Style Wings");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Filo Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Mozarella") && itemList.GetComponent<itemList>().currentItems.Contains("Bacon"))
        {
            Debug.Log("Bacon & Mozarella Sticks");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Coconut Milk") && itemList.GetComponent<itemList>().currentItems.Contains("Condensed Milk") && itemList.GetComponent<itemList>().currentItems.Contains("Cocoa Powder"))
        {
            Debug.Log("Easy Fudge Pops");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Puff Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Bacon") && itemList.GetComponent<itemList>().currentItems.Contains("Egg"))
        {
            Debug.Log("Bacon Turnovers");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Puff Pastry") && itemList.GetComponent<itemList>().currentItems.Contains("Sausages") && itemList.GetComponent<itemList>().currentItems.Contains("Egg"))
        {
            Debug.Log("Sausage Rolls");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Chicken Wings") && itemList.GetComponent<itemList>().currentItems.Contains("Garlic") && itemList.GetComponent<itemList>().currentItems.Contains("Mixed Herbs"))
        {
            Debug.Log("Garlic & Herb Wings");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Egg Whites") && itemList.GetComponent<itemList>().currentItems.Contains("Caster Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Strawberries"))
        {
            Debug.Log("Strawberry Meringues");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Egg Whites") && itemList.GetComponent<itemList>().currentItems.Contains("Caster Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Lemon"))
        {
            Debug.Log("Lemon Meringues");
            recipeCorrect = true;
        }

        if (itemList.GetComponent<itemList>().currentItems.Contains("Butter") && itemList.GetComponent<itemList>().currentItems.Contains("Light Muscavado Sugar") && itemList.GetComponent<itemList>().currentItems.Contains("Condensed Milk"))
        {
            Debug.Log("Easy Caramel");
            recipeCorrect = true;
        }
    }


    public void Update()
    {
        if (recipeCorrect == true)
        {
            buttonEdge.GetComponent<Renderer>().material = itemMaterials[2];

            timer += Time.deltaTime;
            Debug.Log(timer);


            if (timer > 5.0f)
            {
                buttonEdge.GetComponent<Renderer>().material = itemMaterials[0];
                timer = 0.0f;
                recipeCorrect = false;

            }
        }

        if (recipeIncorrect == true)
        {
            buttonEdge.GetComponent<Renderer>().material = itemMaterials[3];

            timer += Time.deltaTime;
            Debug.Log(timer);

            if (timer > 5.0f)
            {
                buttonEdge.GetComponent<Renderer>().material = itemMaterials[0];
                timer = 0.0f;
                recipeIncorrect = false;

            }
        }


    }
}
