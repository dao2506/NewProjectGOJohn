using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ObstacleBehaviourScript : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    public Vector3 oldPosition;
    private GameObject obj;

    public float maxX;
    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 5;
        moveRange = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3( -1 * Time.smoothDeltaTime * moveSpeed, 0, 0));
        //Debug.Log(player.transform.position.x +"," + player.transform.position.y);
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.Translate(oldPosition);

        }
    }

}

