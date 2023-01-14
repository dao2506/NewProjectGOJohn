using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoosePlayerButton : MonoBehaviour
{

    private int index;
    private string[] charactersnames = { "Chicken John", "Eagle", "Yellow Bird" };
    private bool flat;
    [SerializeField] GameObject[] characters;
    [SerializeField] TextMeshProUGUI charactersname;

    public static GameObject selectedCharacters;
    private void Start()
    {
        index = 0;
        flat = false;
        //SelectCharacter();
    }

    public void OnPreButtonClick()
    {
        if (index > 0)
        {
            index--;
        }
        //return true;
        SelectCharacter();
    }

    public void OnNextButtonClick() {
        
        if (index < characters.Length -1 )
        {
            index++;
        }
        SelectCharacter();
        //return true;
    }

    private void SelectCharacter()
    {
        //isSelected.transform.T;
        for (int i = 0;i< characters.Length;i++)
        {
            if (i == index)
            {
                selectedCharacters = characters[i];
                charactersname.text = characters[i].name;
            }
        }
        Debug.Log("Index=" + index);
        Debug.Log("Lenght " + characters.Length);
    }
        
}
