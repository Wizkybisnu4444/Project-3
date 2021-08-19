using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;

    public void StartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditScene()
    {
        creditsPanel.SetActive(true);
    }

    public void QuitScene()
    {
        Debug.Log("Quitting Scene...");
        Application.Quit();
    }

    public void BackFromCredits()
    {
        creditsPanel.SetActive(false);
    }

}
