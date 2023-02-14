using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed;

    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;
    private int score1;
    private int score2;
    // Start is called before the first frame update
    void Start()
    {

        ball = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {

        // to make the ball move randomly 
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ball.velocity = new Vector2(speed * x, speed * y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rightEdge"))
        {
            // increase score for player2
            score2++;
            player2Score.text = score2.ToString();

            // reset the ball
            Reset();
        }


        if (collision.gameObject.CompareTag("leftEdge"))
        {
            // increase score for player1
            score1++;
            player1Score.text = score1.ToString();

            // reset the ball
            Reset();
        }

    }

    private void Reset()
    {
        ball.transform.position = new Vector2(0.5f, 0.5f);
    }
}
