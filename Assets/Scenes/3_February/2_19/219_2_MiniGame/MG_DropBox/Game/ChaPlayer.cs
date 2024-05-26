using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaPlayer : MonoBehaviour
{
    public InfoMenu_S InfoMenu_S;
    public MainMenu_s MainMenu_s;

    private Rigidbody2D rb;
    private bool moveLeft = false;
    private bool moveRight = false;
    private float sideMove;
    public float speed = 5;
    public int score = 0;
    public TMP_Text ScoreTXT;
    public TMP_Text timeText;
    private float time;
    public SpriteRenderer playerSpriteRenderer;

    void Start()
    {
        MainMenu_s.scenenumber++;
        rb = GetComponent<Rigidbody2D>();
        ScoreTXT.text = "Score : 0";
    }

    private void Awake()
    {
        time = 45f; 
        Application.targetFrameRate = 60;
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
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(0);
            if (score > 15)
            {
                InfoMenu_S.C_score += 5;
                SceneManager.LoadScene(MainMenu_s.scenenumber);//성공
            }
            else
            {
                InfoMenu_S.C_score -= 5;
                MainMenu_s.scenenumber++;
                SceneManager.LoadScene(MainMenu_s.scenenumber);//실패
            }
        }
        timeText.text = Mathf.Ceil(time).ToString();
    }

    public void MovePlayer()
    {
        if (moveLeft)
        {
            sideMove = -speed;
            playerSpriteRenderer.flipX = false;
        }
        else if (moveRight)
        {
            sideMove = speed;
            playerSpriteRenderer.flipX = true;
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