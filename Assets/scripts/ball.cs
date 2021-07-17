using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private audiosource audio;
    private text text;
    [SerializeField] private Rigidbody2D rb;

    int ball_score = 0;

    void Start()
    {
        rb.velocity = new Vector2(4f, 4f);
        audio = audiosource.Instance;
        text = text.Instance;
    }
   
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("lose"))
        {
            Debug.Log("End");
        }
        if (col.gameObject.CompareTag("block"))
        {
            Destroy(col.gameObject);
            audio.audio_blocks.Play();
            ball_score++;
            text.score.text = ball_score.ToString();
        }
        if (col.gameObject.CompareTag("border"))
        {
            audio.audio_border.Play();
        }
        if (col.gameObject.CompareTag("platform"))
        {
            audio.audio_platform.Play();
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y <= -5.5f)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
            }
            text.result.text = "YOU LOSE!!! PRESS SPACE FOR RESTART";
        }
        if (ball_score == 16)
        {
            Time.timeScale = 0;
            text.result.text = "YOU WIN!!!";
        }
    }
}
