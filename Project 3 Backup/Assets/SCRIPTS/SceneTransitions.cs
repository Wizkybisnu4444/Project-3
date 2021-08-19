using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;

    public void StartScene()
    {
        StartCoroutine(LoadScene());
    }


    public void QuitScene()
    {
        Debug.Log("Quitting Scene...");
        Application.Quit();
    }


    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
