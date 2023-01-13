using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeMenu()
    {
        //returnMainmenu
        UnityEngine.Application.LoadLevel("MainMenu");
    }

    public void loadCredit()
    {
        //returnMainmenu
        UnityEngine.Application.LoadLevel("Credit");
    }
}
