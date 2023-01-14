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
    private string[] characterNames = { "Chicken John", "Eagle", "Yellow Bird" };
    public static string selectedCharacterName = "Chicken John";
    
    public void NextOption()
    {
        selectedCharacter = selectedCharacter + 1;
        if (selectedCharacter == characters.Count)
        {
            selectedCharacter = 0;
        }
        sr.sprite = characters[selectedCharacter];
        selectedCharacterName= characterNames[selectedCharacter];
        //Debug.Log(characterNames[selectedCharacter]);
    }

    public void PreOption()
    {
        selectedCharacter = selectedCharacter - 1;
        if (selectedCharacter < 0)
        {
            selectedCharacter = characters.Count - 1;
        }
        sr.sprite = characters[selectedCharacter];
        selectedCharacterName = characterNames[selectedCharacter];
    }

    public void PlayGame()
    {
        string path = "Assets/Resources/Birds/Prefabs/Custom/Chicken John.prefab";
        switch (selectedCharacter) {
            case 0:
                path = "Assets/Resources/Birds/Prefabs/Custom/Chicken John.prefab";
                break;
            case 1:
                path = "Assets/Resources/Birds/Prefabs/Custom/Eagle.prefab";
                break;
            case 2:
                path = "Assets/Resources/Birds/Prefabs/Custom/Yellow Bird.prefab";
                break;

        }
        PrefabUtility.SaveAsPrefabAsset(playerCharacter,  path);
        UnityEngine.Application.LoadLevel("Levels/Level1");
    }
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
