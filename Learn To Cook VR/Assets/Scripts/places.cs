using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class places : MonoBehaviour
{

    public GameObject item;
    public string itemValue;

    private void OnTriggerEnter(Collider collider)
    {
        item = collider.gameObject;

        Debug.Log("Item " + itemValue + " is " + item.name);


    }



}
