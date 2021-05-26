using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public GameObject firstButtons;
    public GameObject secondButtons;


    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }

    public void EscapeTheOffice()
    {
        SceneManager.LoadScene(2);
    }

    public void RegistrationScene()
    {
        firstButtons.SetActive(false);
        secondButtons.SetActive(true);
    }
}
