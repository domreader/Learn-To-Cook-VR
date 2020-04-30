using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreen : MonoBehaviour
{

    public float time = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(intro());
    }

    // Update is called once per frame


    IEnumerator intro()
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("Menu Screen");

    }

    

}

