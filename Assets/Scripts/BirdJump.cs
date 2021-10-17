using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{

    Rigidbody2D rg;
    AudioSource audioSource;
    public float JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            rg.velocity = Vector2.up * JumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
            PlayerPrefs.SetInt("bestScore", Score.score);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
