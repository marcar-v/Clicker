using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void StartGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        Application.Quit();
    }
}
