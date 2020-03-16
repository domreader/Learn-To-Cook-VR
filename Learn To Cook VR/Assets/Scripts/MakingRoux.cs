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
    bool isOnHob = false;
    bool isOvercooked = false;
    Color greenColor = new Vector4(0.0f, 0.1f, 0.0f, 0.1f);
    Color redColor = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);

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

        if (isButterAdded == true && isFlourAdded == true && allIngredientsPresent == false)
        {

            Debug.Log("Congratulations ... You Can Drop Stuff In A Pan");
            Debug.Log("Now Put The Pan On The Heat Till Flour Is Cooked Out");

            allIngredientsPresent = true;
            
        }

        if (collider.gameObject.tag == "Hob" && allIngredientsPresent == true)
        {

            isOnHob = true;
            Debug.Log("Cooking time is " + (timer) + "Seconds" );

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

        if (isOvercooked == false && collider.gameObject.tag == "placeMat")
        {

            Debug.Log("Hmmm ... That is not correct");

        }
    }

    private void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject.tag == "Hob" && allIngredientsPresent == true)
        {

            isOnHob = false;
            Debug.Log("Cooking time is done");
            

        }

    }

    private void Update()
    {

        if (isOnHob == true)
        {

            timer += Time.deltaTime;

            print(timer);

        }

        if (isOvercooked == false)
        {
            if (timer >= 12)
            {


                gameObject.GetComponent<Renderer>().material.color = redColor;

                Debug.Log("Try Again");
                GameObject.Find("Image").GetComponent<Image>().sprite = sprites[4];
                SceneManager.LoadScene("Lose Room");
                isOvercooked = true;

            }
            else if (timer > 6)
            {

                gameObject.GetComponent<Renderer>().material.color = greenColor;
                isEverythingCorrect = true;
                GameObject.Find("Image").GetComponent<Image>().sprite = sprites[3];

            }
        }
    }    

}
