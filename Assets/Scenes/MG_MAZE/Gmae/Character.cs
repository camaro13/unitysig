using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public InfoMenu_S InfoMenu_S;

    private Rigidbody2D rb;
    private bool moveLeft = false;
    private bool moveRight = false;
    private bool moveUp = false;
    private bool moveDown = false;
    private float XMove;
    private float YMove;
    public float speed = 5;
    private float time;
    public TMP_Text timeText;
    public static int exit_S = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        time = 150f;
        Application.targetFrameRate = 60;
    }

    public void LeftBtnDown()
    {
        moveLeft = true;
    }
    public void LeftBtnUp()
    {
        moveLeft = false;
    }
    public void RightBtnDown()
    {
        moveRight = true;
    }
    public void RightBtnUp()
    {
        moveRight= false;
    }
    public void UpBtnDown()
    {
        moveUp = true;
    }
    public void UpBtnUp()
    {
        moveUp= false;
    }
    public void DownBtnDown()
    {
        moveDown= true;
    }
    public void DownBtnUp()
    {
        moveDown = false;
    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time < 0)//½ÇÆÐ
        {
            InfoMenu_S.C_score -= 5;
            SceneManager.LoadScene(0);
        }
        timeText.text = Mathf.Ceil(time).ToString();
    }

    public void MovePlayer()
    {
        XMove = 0; YMove = 0;
        if (moveLeft)
        {
            XMove = -speed;
        }
        else if (moveRight)
        {
            XMove = speed;
        }
        else if (moveUp)
        {
            YMove = speed;
        }
        else if (moveDown)
        {
            YMove = -speed;
        }
    }

    private void FixedUpdate()
    {
        //rb.velocity = new UnityEngine.Vector2(sideMove, rb.velocity.y);
        //rb.velocity = new UnityEngine.Vector2 (upMove, rb.velocity.x);
        this.transform.Translate(XMove/50, YMove/50, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            exit_S++;
            Debug.Log(exit_S);
            if (exit_S == 3)
            {
                InfoMenu_S.C_score += 5;
                SceneManager.LoadScene(0);
            }
            Destroy(gameObject);
            
        }
    }
}
