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

    [SerializeField] TextMeshProUGUI distanceText;
    private float distance;
    void Update()
    {
        distanceText.text = distance.ToString("F2");

        speedMultiplier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;

        distance += Time.deltaTime * 0.8f;

        if(timer > timeBetweenSpawn )
        {
            timer = 0;
            int randomNumber = Random.Range(0, spawnPoints.Length);
            Instantiate(spawnObject, spawnPoints[randomNumber].transform.position, Quaternion.identity);
        }
    }
}
