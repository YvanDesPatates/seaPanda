using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public bool isTitlePage = false;

    public bool isGameOver = false;
    public Animator fadeSystem;
    void Update() {
        if (PlayerOxygen.currentOxygenLevel <= 0) {
            StartCoroutine(loadPage("GameOver"));
        }

        if (isTitlePage && Input.GetKeyDown("space")) {
            StartCoroutine(loadPage("SampleScene"));
        }

        if (isGameOver && Input.GetKeyDown("space")) {
            StartCoroutine(loadPage("Titre"));
        }
    }

    public IEnumerator loadPage(string pageName) {
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(pageName); 
    }
}
