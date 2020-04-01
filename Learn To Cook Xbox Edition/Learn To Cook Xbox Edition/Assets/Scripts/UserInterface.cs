using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject mainBookUI;
    public GameObject mainInstructionUI;
    public GameObject inventoryUI;

    public static bool isGamePaused = false;
    public static bool isBookOpen = false;
    public static bool isInventoryOpen = false;

    public GameObject[] pages;

    int currentPage = 0;



    void Start()
    {
        pages[0].SetActive(true);
        currentPage = 0;
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
}
