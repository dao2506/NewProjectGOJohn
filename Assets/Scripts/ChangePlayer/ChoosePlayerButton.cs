using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoosePlayerButton : MonoBehaviour
{

    private int index;
    private string[] charactersnames = { "Chicken John", "Eagle", "Yellow Bird" };
    [SerializeField] GameObject[] characters;
    [SerializeField] TextMeshProUGUI charactersname;

    public static GameObject selectedCharacters;
    private void Start()
    {
        index = 0;
        
        SelectCharacter();
    }

    public void OnPreButtonClick()
    {
        Debug.Log("Click PreBtn");
        if (index > 0)
        {
            index--;
        }
       
        SelectCharacter();
    }

    public void OnNextButtonClick() {
        Debug.Log("Click NextBtn");
        if (index < characters.Length -1 )
        {
            index++;
        }
       
        SelectCharacter();
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
