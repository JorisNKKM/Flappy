using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        
    }
}
