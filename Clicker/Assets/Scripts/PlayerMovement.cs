using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    private Rigidbody2D rb;
    private bool isGrounded;

    bool isDead;
    [SerializeField] GameObject gameOverCanvas;

    AudioManager audioManager;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();

    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            audioManager.PlaySFX(audioManager.jumpSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
        if(collision.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            GameOver();

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void GameOver()
    {
        if(isDead)
        {
            audioManager.PlaySFX(audioManager.gameOverSound);
            Time.timeScale = 0f;
            gameOverCanvas.SetActive(true);
        }
    }
}
