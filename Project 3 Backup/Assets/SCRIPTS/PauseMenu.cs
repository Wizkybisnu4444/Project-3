using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused = false;
    public GameObject PauseGame;
    public Animator transitionAnim;
    public float myTimer;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        myTimer += Time.deltaTime;
        if(myTimer >= 5)
        {
            myTimer = 5;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && myTimer >= 1)
        {
            isPaused = true;
            PauseGame.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        StartCoroutine(ResumeScene());
    }

    public void RestartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        isPaused = false;
        PauseGame.SetActive(false);
        Cursor.visible = true;
        Time.timeScale = 1;
    }

    IEnumerator ResumeScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        PauseGame.SetActive(false);
        Cursor.visible = false;
    }

}
