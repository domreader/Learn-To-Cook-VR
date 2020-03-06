using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakingRoux : MonoBehaviour
{

    bool isButterAdded = false;
    bool isFlourAdded = false;
    bool isStockAdded = false;
    bool isMilkAdded = false;
    bool allIngredientsPresent = false;
    bool isEverythingCorrect = false;
    float timer;

    [SerializeField]
    GameObject Flour;
    [SerializeField]
    GameObject Butter;
    [SerializeField]
    GameObject Milk;
    [SerializeField]
    GameObject Stock;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Image").GetComponent<Image>().sprite = sprites[0];

        Debug.Log("You even listening");
    }

    void OnTriggerEnter(Collider collider)
    {


        if (collider.gameObject.tag == "Butter")
        {

            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[1];
            Debug.Log("Butter Added");
            isFlourAdded = true;
            Destroy(Butter);

        }

        if (collider.gameObject.tag == "Flour")
        {

            GameObject.Find("Image").GetComponent<Image>().sprite = sprites[2];
            Debug.Log("Flour Added");
            isButterAdded = true;
            Destroy(Flour);

        }

        if (isButterAdded == true && isFlourAdded == true)
        {

            Debug.Log("Congratulations ... You Can Drop Stuff In A Pan");
            Debug.Log("Now Put The Pan On The Heat Till Flour Is Cooked Out");

            allIngredientsPresent = true;

        }

        if (collider.gameObject.tag == "Hob" && allIngredientsPresent == true)
        {

           Debug.Log("Cooking time is " + (timer + 1) + "Seconds" );
          
            timer += Time.deltaTime;

           if (timer >= 5)
            {

                Debug.Log("Take the pan off heat");
                isEverythingCorrect = true;
                GameObject.Find("Image").GetComponent<Image>().sprite = sprites[3];
               
            }

            if (timer >= 10)
            {
                Debug.Log("Try Again");
                GameObject.Find("Image").GetComponent<Image>().sprite = sprites[4];
                isEverythingCorrect = false;
            }

        }

        if (isEverythingCorrect == true && collider.gameObject.tag == "Milk")
        {
            Debug.Log("That's Now A Bechemel Sauce ... Go You");
            isMilkAdded = true;
            Destroy(Milk);
        }

        if (isEverythingCorrect == true && collider.gameObject.tag == "Stock")
        {
            Debug.Log("That's Now A Veloute Sauce ... Look At You Being All Fancy");
            isStockAdded = true;
            Destroy(Stock);
        }

        if (isEverythingCorrect == true && collider.gameObject.tag == "placeMat")
        {
        
            SceneManager.LoadScene("Menu Screen");

        }

        if (isEverythingCorrect == false && collider.gameObject.tag == "placeMat")
        {

            Debug.Log("Hmmm ... That is not correct");

        }
    }
}
