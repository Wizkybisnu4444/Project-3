using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused = false;
    public GameObject PauseGame;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            isPaused = true;
            PauseGame.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        PauseGame.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        /*isPaused = false;
        PauseGame.SetActive(false);*/
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
