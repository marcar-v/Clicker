using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] GameObject spawnObject;
    [SerializeField] float timer;
    [SerializeField] float timeBetweenSpawn;

    public float speedMultiplier;
    [SerializeField] Animator clickToJumpAnim;
    [SerializeField] GameObject clickToJumpText;



    private void Start()
    {
        Invoke("PlayAnimation", 0.5f);
    }


    void PlayAnimation()
    {
        clickToJumpText.SetActive(true);
        clickToJumpAnim.Play("ClicktoJumpAnim");
    }

    void Update()
    {
        speedMultiplier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;

        if(timer > timeBetweenSpawn)
        {
            timer = 0;
            int randomNumber = Random.Range(0, spawnPoints.Length);
            Instantiate(spawnObject, spawnPoints[randomNumber].transform.position, Quaternion.identity);
        }
    }


}
