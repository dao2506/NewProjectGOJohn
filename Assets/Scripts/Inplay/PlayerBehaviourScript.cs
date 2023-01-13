using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript: MonoBehaviour
{
    /*public float moveSpeed;
    public float moveRange;

    public GameObject player;
    private Vector3 oldPos;
    public Vector3 newPos;
    private int director;
    public float flyPower = 100;
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //audioSource.Play();
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
    }

    void moveAround()
    {
        player.transform.Translate(new Vector3(0, director * Time.smoothDeltaTime * moveSpeed, 0));
        //Debug.Log(player.transform.position.x +"," + player.transform.position.y);
        if (Vector3.Distance(oldPos, player.transform.position) > moveRange)
        {
            director *= -1;
        }
    }

    void moveUp()
    {
        newPos = player.transform.position;
        player.transform.Translate(new Vector3(0, 1 * Time.smoothDeltaTime * moveSpeed, 0));
    }

    void moveDown()
    {
        newPos = player.transform.position;
        player.transform.Translate(new Vector3(0, -1 * Time.smoothDeltaTime * moveSpeed, 0));
    }

    void moveForwake()
    {
        player.transform.Translate(new Vector3(Time.smoothDeltaTime * moveSpeed, 0, 0));
    }
  

    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }

    void EndGame()
    {
        Debug.Log("End game");
    }*/
    Vector3 mousePos;
    public float moveSpeed = 5;
    public float minX = -5.5f;
    public float maxX = 5.5f;
    public float minY = -3;
    public float maxY = 3;
    // Use this for initialization
    void Start()
    {
        mousePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), 0);
        }
        transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed * Time.deltaTime);
    }

}
