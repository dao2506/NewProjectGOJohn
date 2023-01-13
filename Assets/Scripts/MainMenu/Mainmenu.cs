using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{

    public void loadCutScreen() {
        UnityEngine.Application.LoadLevel("CutScene");
    }

    public void loadLv1() { 
        UnityEngine.Application.LoadLevel("Level1");
    }
    public void loadSettingMenu(){
        UnityEngine.Application.LoadLevel("SettingMenu");
    }
    public void loadChangePlayer(){
        UnityEngine.Application.LoadLevel("ChoosePlayer");
    }

    public void loadCredit(){
        UnityEngine.Application.LoadLevel("Credit");
    }

    public void loadScoreBoard() {
        UnityEngine.Application.LoadLevel("ScoreBoard");
    }
}
