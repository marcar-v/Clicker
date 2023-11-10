using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    DistanceController bestDistance;
    AudioManager audioManager;

    [SerializeField] GameObject startingAnim;
    [SerializeField] GameObject endingAnim;

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
        startingAnim.SetActive(true);
        Invoke("DisableStartingTransition", 1.5f);
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1f;
    }

    void DisableStartingTransition()
    {
        startingAnim.SetActive(false);
    }

    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.clickSound);
        endingAnim.SetActive(true);
        Application.Quit();
    }

}
