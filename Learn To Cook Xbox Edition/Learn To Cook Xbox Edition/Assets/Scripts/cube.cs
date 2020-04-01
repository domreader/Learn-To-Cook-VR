using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{

    PlayerControls controls;


    Vector3 move;
    Vector3 rotate;
    float lockPos = 0;
    float speed = 2.0f;

    public static bool isGamePaused = false;
    public static bool isBookOpen = false;
    public static bool isInventoryOpen = false;
    public static bool collisionDetected = false;
    
    public GameObject pauseMenuUI;
    public GameObject mainBookUI;
    public GameObject mainInstructionUI;
    public GameObject inventoryUI;

    public static int meat;
    public static int vegetables;
    public static int desserts;
    public static int drinks;

    Collision collision;

    int currentPage = 0;
    int numberOfItemsInventory;

    public GameObject[] pages;


    void Awake()
    {

        controls = new PlayerControls();

        controls.playerControls.OpeningBook.started += ctx => selectedBook();
        controls.playerControls.OpeningBook.canceled += ctx => deselectedBook();

        controls.playerControls.Shrink.performed += ctx => Shrink();

        controls.playerControls.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.playerControls.Move.canceled += ctx => move = Vector2.zero;

        controls.playerControls.RotateLook.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.playerControls.RotateLook.canceled += ctx => rotate = Vector2.zero;

        controls.playerControls.Pause.started += ctx => gamePaused();
        controls.playerControls.Pause.canceled += ctx => gamePlaying();

        controls.playerControls.TurningPageLeft.started += ctx => turnPageLeft();
        controls.playerControls.TurningPageRight.started += ctx => turnPageRight();

        controls.playerControls.Interact.started += ctx => pickUp();

        controls.playerControls.Inventory.started += ctx => inventoryOpen();
        controls.playerControls.Inventory.canceled += ctx => inventoryClosed();

        void Start()
        {
            pages[0].SetActive(true);
            currentPage = 0;
        }

        void pickUp()
        {
            if (collisionDetected == true)
            {
                Debug.Log("Add item to inventory");

               
                Debug.Log("You have" + meat + "items of meat");
                Debug.Log("You have" + vegetables + "items of vegetables");
                Debug.Log("You have" + desserts + "items of dessert");
                Debug.Log("You have" + drinks + "items of drinks");


            }
        }
    }
    void Shrink()
    {

        transform.localScale /= 1.1f;

    }
    void gamePaused()
    {

        if (isGamePaused)
        {
            Resume();
        }

        else
        {
            Pause();
        }


    }

    void gamePlaying()
    {

        if (isGamePaused == true)
        {
            Pause();
        }

        else
        {
            Resume();
        }


    }
    void Resume()
    {

        pauseMenuUI.SetActive(false);
        mainInstructionUI.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;

    }

    void Pause()
    {

        pauseMenuUI.SetActive(true);
        mainInstructionUI.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;

    }

    public void inventoryOpen()
    {
        if (isInventoryOpen)
        {
            closeInventory();
        }

        else
        {
            openInventory();
        }
    }

    public void openInventory()
    {
        mainInstructionUI.SetActive(false);
        inventoryUI.SetActive(true);
        Time.timeScale = 0f;
        isInventoryOpen = true;
    }

    public void closeInventory()
    {
        inventoryUI.SetActive(false);
        mainInstructionUI.SetActive(true);
        Time.timeScale = 1f;
        isInventoryOpen = false;
    }

    public void inventoryClosed()
    {
        if (isInventoryOpen == true)
        {
            openInventory();

        }

        else
        {
            closeInventory();
        }
    }

    public void selectedBook()
    {

        if (isBookOpen)
        {
            bookClosed();
        }

        else
        {
            bookOpen();
        }

    }

    public void turnPageLeft()
    {

        if ((currentPage - 1) >= 0)
        {
            pages[currentPage].SetActive(false);
            pages[currentPage - 1].SetActive(true);
            currentPage -= 1;
        }

    }
    public void turnPageRight()
    {

        if (isBookOpen == true)
        {

            if ((currentPage + 1) < pages.Length)
            {
                pages[currentPage].SetActive(false);
                pages[currentPage + 1].SetActive(true);

                currentPage += 1;
            }

        }
    }
    public void deselectedBook()
    {

        if (isBookOpen == true)
        {

            bookOpen();

        }

        else
        {

            bookClosed();

        }

    }
    public void bookClosed()
    {

        mainBookUI.SetActive(false);
        mainInstructionUI.SetActive(true);
        Time.timeScale = 1f;
        isBookOpen = false;

    }

    public void bookOpen()
    {

        mainBookUI.SetActive(true);
        mainInstructionUI.SetActive(false);
        Time.timeScale = 0f;
        isBookOpen = true;

    }

    void Update()
    {

        Vector3 m = new Vector3(-move.x, lockPos, move.z + -move.y) * Time.deltaTime * speed;
        transform.Translate(m, Space.Self);

        Vector3 r = new Vector3(lockPos, rotate.x , lockPos) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.Self);
        //  Vector3 l = new Vector3(rotate.y, lockPos, lockPos) * 100f * Time.deltaTime;
        //  transform.Rotate(l, Space.Self);

    }

    void inventory()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Meat")
        {
            Debug.Log("This is meat");
            meat++;
            collisionDetected = true;
        }

        if (collider.gameObject.tag == "Vegetables")
        {
            Debug.Log("Those are vegetables");
            vegetables++;
            collisionDetected = true;

        }

        if (collider.gameObject.tag == "Desserts")
        {
            Debug.Log("Those are items for desserts");
            desserts++;
            collisionDetected = true;

        }

        if (collider.gameObject.tag == "Drinks")
        {
            Debug.Log("Those are items for drinks");
            drinks++;
            collisionDetected = true;

        }


    }

    void OnEnable()
    {
        controls.playerControls.Enable();
    }

    void onDisable()
    {
        controls.playerControls.Disable();
    }
        
}

