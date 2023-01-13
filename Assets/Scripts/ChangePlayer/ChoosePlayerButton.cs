using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayerButton : MonoBehaviour
{

    public string playerName;
    // Start is called before the first frame update
    void ChooseJohn()
    {
        playerName = "Chicken John";
        loadLv1();
    }

    void chooseBlue()
    {
        playerName = "Blue Bird";
        loadLv1();
    }

    void chooseYellow()
    {
        playerName = "Yellow Bird";
        loadLv1();
    }

    void chooseEagle()
    {
        playerName = "Eagle";
        loadLv1();
    }

    void chooseOwl() {
        playerName = "Owl";
        loadLv1();
    }

    void loadLv1()
    {
        UnityEngine.Application.LoadLevel("Level1");
    }
}
