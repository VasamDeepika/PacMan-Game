using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public int speed = 3;
    private void Update()
    {
        if (transform.position.x <= -7)
        {
            speed = 3;
        }
        if (transform.position.x >= 10)
        {
            speed = -3;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pacman")
        {
            Destroy(collision.gameObject);
        }

    }
}