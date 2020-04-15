using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemList : MonoBehaviour
{

    public List<string> currentItems;
    public List<GameObject> storedContacts;

    // Start is called before the first frame update
    void Start()
    {
        currentItems = new List<string>();
        storedContacts = new List<GameObject>();
    }




}
