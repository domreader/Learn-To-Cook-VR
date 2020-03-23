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
    public GameObject pauseMenuUI;

    void Awake()
    {
        controls = new PlayerControls();

        controls.playerControls.Grow.performed += ctx => Grow();

        controls.playerControls.Shrink.performed += ctx => Shrink();

        controls.playerControls.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.playerControls.Move.canceled += ctx => move = Vector2.zero;


        controls.playerControls.RotateLook.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.playerControls.RotateLook.canceled += ctx => rotate = Vector2.zero;

        controls.playerControls.Pause.started += ctx => gamePaused();
        controls.playerControls.Pause.canceled += ctx => gamePlaying();


    }

    void Grow()
    {
        transform.localScale *= 1.1f;
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

