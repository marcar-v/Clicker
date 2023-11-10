using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    AudioManager audioManager;
    [SerializeField] GameObject startingAnim;
    [SerializeField] GameObject endingAnim;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void StartGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        endingAnim.SetActive(true);
        Invoke("DisableEndingTransition", 1.5f);
        SceneManager.LoadScene(1);
    }
    void DisableEndingTransition()
    {
        endingAnim.SetActive(false);
    }

    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        endingAnim.SetActive(true);
        Application.Quit();
    }
}
