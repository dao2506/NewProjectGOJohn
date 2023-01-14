using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator animate;

    private float moveSpeed;
    private float jumpForce;
    private bool isJump;
    private float moveVertical;
    private float moveHorizontal;

    public static int numCoin;
    public static int numScore;
    public static string activeEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        animate = gameObject.GetComponent<Animator>();

        moveSpeed = .3f;
        jumpForce = .2f;
        isJump = false;
        numCoin = 0;    // Change to current player's number of coin
        numScore = 0;
        activeEffect = "";
    }

    // Update is called once per frame
    void Update()
    { 
        moveHorizontal = Input.GetAxisRaw("Horizontal");    // Using Input.GetButtonDown for mobile UI

        animate.SetFloat("IsJump", moveHorizontal);
    }

    void FixedUpdate()
    {
        rb2D.AddForce(new Vector2(0f, moveSpeed), ForceMode2D.Impulse);
        //Debug.Log(moveSpeed);

        if (!isJump && moveHorizontal > 0.1f)
        {
            // rb2D.AddForce(new Vector2(jumpForce, 0f), ForceMode2D.Impulse);
            Vector3 jumpPos = transform.position;
            jumpPos.x += jumpForce;
            transform.position = jumpPos;
        }
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MainCamera")
        {
            //Debug.Log("Hit camera");
            ChangeDirection();
            //Debug.Log("Hit: " + moveSpeed);
        }
        else if (collision.tag == "coc")
            Endgame();
        //Destroy(gameObject);
        else if (collision.tag == "Space")
            numScore += 1;
        else
            ItemsBehavior.TriggerItem(collision.tag);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "MainCamera")
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        moveSpeed *= -1;
    }

    public void Endgame()
    {
        UnityEngine.Application.LoadLevel("Endgame");
    }
}
