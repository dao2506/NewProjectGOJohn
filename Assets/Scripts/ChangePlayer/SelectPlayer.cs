using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer sr;
    public List<Sprite> characters = new List<Sprite>();
    private int selectedCharacter = 0;
    public GameObject playerCharacter;
    
    public void NextOption()
    {
        selectedCharacter = selectedCharacter + 1;
        if (selectedCharacter == characters.Count)
        {
            selectedCharacter = 0;
            sr.sprite = characters[selectedCharacter];
        }
    }

    public void PreOption()
    {
        selectedCharacter = selectedCharacter - 1;
        if (selectedCharacter < 0)
        {
            selectedCharacter = characters.Count - 1;
            sr.sprite = characters[selectedCharacter];
        }
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerCharacter, "Assets/Background/Bird in Select menu/Bird in Select menu.png");
        UnityEngine.Application.LoadLevel("Level1");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}