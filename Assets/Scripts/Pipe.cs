using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static float speed;
    public float minX;
    public float maxX;


    private void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x -1;
        maxX= Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + 1;
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x<minX)
        {
            var height = Random.Range(1f, 5f);
            transform.position = new Vector3(maxX,height,0);
        }
    }
}
