using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;


public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void loadCutScreen()
    {

        UnityEngine.Application.LoadLevel("CutScene");
    }

    public void loadLv1()
    {

        UnityEngine.Application.LoadLevel("Level1");
    }
}
