using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPlacement : MonoBehaviour
{
    int meat = cube.meat;
    int vegetables = cube.vegetables;
    int desserts = cube.desserts;
    int drinks = cube.drinks;
    public static bool hasCollided = false;


    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == ("Meat"))
        {
            Debug.Log("Collision with Meat recorded");
            meat--;
        }

        if (collider.gameObject.tag == ("Vegetables"))
        {
            Debug.Log("Collision with Vegetables recorded");
            vegetables--;
        
        }

        if (collider.gameObject.tag == ("Desserts"))
        {
            Debug.Log("Collision with Desserts recorded");
            desserts--;
        }

        if (collider.gameObject.tag == ("Drinks"))
        {
            Debug.Log("Collision with Drinks recorded");
            drinks--;

            Debug.Log("Now have" + drinks + "drinks");
        }


    }


}
