using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy3Movement : MonoBehaviour
{
    public int speed = 3;
    private void FixedUpdate()
    {
        if (transform.position.y <= 7)
        {
            speed = 3;
        }
        if (transform.position.y >= 40)
        {
            speed = -3;
        }
        transform.Translate(0, speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pacman")
        {
            Destroy(collision.gameObject);
        }

    }
}