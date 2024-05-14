using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ChaPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft = false;
    private bool moveRight = false;
    private float sideMove;
    public float speed = 5;
    public int score = 0;
    public TMP_Text ScoreTXT;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ScoreTXT.text = "Score : 0";
    }

    public void LeftBtnDown()
    {
        moveLeft = true;
    }

    public void LeftBtnUp()
    {
        moveLeft  = false;
    }
    public void RightBtnDown()
    {
        moveRight = true;
    }

    public void RightBtnUp()
    {
        moveRight=false;
    }

    void Update()
    {
        MovePlayer();
        
    }

    public void MovePlayer()
    {
        if (moveLeft)
        {
            sideMove = -speed;
        }
        else if (moveRight)
        {
            sideMove = speed;
        }
        else
        {
            sideMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new UnityEngine.Vector2(sideMove, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            score++;
            ScoreTXT.text = "Score : " + score.ToString();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (score > 0)
            {
                score--;
                ScoreTXT.text = "Score : " + score.ToString();
            }
        }
    }
}