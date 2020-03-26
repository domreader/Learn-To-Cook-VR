using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{

    PlayerControls controls;
    Collider collider;

    Vector3 move;
    Vector3 rotate;
    float lockPos = 0;
    float speed = 2.0f;

    public static bool isGamePaused = false;
    public static bool isBookOpen = false;
    public GameObject pauseMenuUI;
    public GameObject mainBookUI;

    public GameObject[] pages;
    int i = 0;
    

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

        controls.playerControls.TurningPageLeft.performed += ctx => turnPageLeft();
        controls.playerControls.TurningPageRight.performed += ctx => turnPageRight();

      
    }


    void selectedBook()
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

    void turnPageLeft()
    {
        if (isBookOpen == true)
        {

            pages[0].SetActive(true);
            pages[1].SetActive(false);
        }
        
    }
    void turnPageRight()
    {

        if(isBookOpen == true)
        {
            pages[0].SetActive(false);
            pages[1].SetActive(true);
          //  pages[1].SetActive(false);
            //  pages[2].SetActive(true);
           
        }

    }
    void deselectedBook()
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
    void bookClosed()
    {

        mainBookUI.SetActive(false);
        Time.timeScale = 1f;
        isBookOpen = false;

    }

    void bookOpen()
    {

        mainBookUI.SetActive(true);
        Time.timeScale = 0f;
        isBookOpen = true;

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
        Time.timeScale = 1f;
        isGamePaused = false;

    }

    void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;

    }

    void Update()
    {

        Vector3 m = new Vector3(-move.x, lockPos, move.z + -move.y) * Time.deltaTime * speed;
        transform.Translate(m, Space.Self);

        Vector3 r = new Vector3(lockPos, rotate.x , lockPos) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.Self);
        //  Vector3 l = new Vector3(rotate.y, lockPos, lockPos) * 100f * Time.deltaTime;
        //  transform.Rotate(l, Space.Self);
        i = pages.Length;

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

