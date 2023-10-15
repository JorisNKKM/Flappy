using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;
    public TMP_Text scoreText;
    public float speed;
    public GameObject endscreen;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& speed>0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y*3f);

        Pipe.speed = speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        
        scoreText.text = score.ToString();
    }
    
    public void Die()
    {
        speed = 0;
        Pipe.speed = 0;
        Invoke("ShowMenu", 1f);


        //var currentScene = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(currentScene);
    }

    void ShowMenu()
    {
        scoreText.text = "";
        endscreen.SetActive(true);
        print("end screen");
    }
}
