using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacDot : MonoBehaviour
{

    // Start is called before the first frame update

    public int score=0;
    public Text ScoreText;
    public AudioClip playerClip;
    ScoreManager scoreManager;

    AudioSource playerAudio;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        playerAudio = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pacman")
        {
            playerAudio.clip = playerClip;
            playerAudio.Play();
            Destroy(this.gameObject);
            scoreManager.IncrementScore();
            // print("Score : " + score);

            
        }

    }
}
