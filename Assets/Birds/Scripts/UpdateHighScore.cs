using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHighScore : MonoBehaviour
{
    public TMP_Text highScoreText;

    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdsController.numScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", BirdsController.numScore);
            highScoreText.text = "High Score: " + BirdsController.numScore.ToString();
        }
    }
}
