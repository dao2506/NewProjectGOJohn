using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class ChangeBG : MonoBehaviour
{
    
    public Vector3 targetPos;

    public float moveSpeed;
    public float moveRange;
    public GameObject BG;
    private Vector3 oldPos;
    //private float oldPosX;
    void Start()
    {
        oldPos = BG.transform.position;
        moveSpeed = 5;
        moveRange = 20;
    }

    void Update()
    {
        BG.transform.Translate(new Vector3(0, -1 * moveSpeed, 0));

        if (Time.time % 40 == 0)
        {
            BG.transform.position = oldPos;
        }
    }
}
