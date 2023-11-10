using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject startingAnim;
    [SerializeField] GameObject endingAnim;

    private void Start()
    {
        startingAnim.SetActive(true);
        Invoke("DisableStartingTransition", 1.5f);
        Invoke("DisableEndingTransition", 1.5f);
    }

    void DisableStartingTransition()
    {
        startingAnim.SetActive(false);
    }

    void DisableEndingTransition()
    {
        endingAnim.SetActive(false);
    }
}
