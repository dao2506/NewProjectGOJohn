using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    


    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Audio");
       
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
    }


    
}
