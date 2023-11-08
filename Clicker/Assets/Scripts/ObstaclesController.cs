using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObstaclesController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed;

    private GameManager gameManager;

    private float timer;

    void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
        rb.velocity = Vector2.left * (speed * gameManager.speedMultiplier);
    }
}
