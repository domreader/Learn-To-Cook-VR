using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour {
    public void GoToRoux()
    {
        SceneManager.LoadScene("Roux");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu Screen");
    }

    public void BurgersAndDogs()
    {
        SceneManager.LoadScene("Burgers & Dogs");
    }

    public void LoseRoom()
    {
        SceneManager.LoadScene("Lose Room");
    }

    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }

}