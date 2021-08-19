using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsTransition : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject creditsPanel;

    public void CreditScene()
    {
        StartCoroutine(LoadScene());
    }

    public void BackFromCredits()
    {
        StartCoroutine(ReturnScene());
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        transitionAnim.SetTrigger("start");
        creditsPanel.SetActive(true);
    }

    IEnumerator ReturnScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        transitionAnim.SetTrigger("start");
        creditsPanel.SetActive(false);
    }

}
