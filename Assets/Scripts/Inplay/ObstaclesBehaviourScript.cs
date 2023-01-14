using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ObstaclesBehaviourScript : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    public Vector3 oldPosition;
    private GameObject obj;
    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 5;
        moveRange = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.transform.position.x +"," + player.transform.position.y);
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.Translate(oldPosition);

        }
    }

   
}
