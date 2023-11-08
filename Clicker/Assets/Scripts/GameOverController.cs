using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    DistanceController bestDistance;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    private void Start()
    {
        bestDistance = GameObject.FindGameObjectWithTag("DistanceController").GetComponent<DistanceController>();

        bestDistance.UpdateBestDistanceTextUI();
    }

    public void RestartGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        Application.Quit();
    }
}
