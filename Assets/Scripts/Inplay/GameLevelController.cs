using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelController : MonoBehaviour
{
    private GameObject mainCharacter;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 initPos= transform.position;
        //string selectedMainCharacter = SelectPlayer.selectedCharacterName;

        Instantiate(Resources.Load("Birds/Prefabs/Custom/" + SelectPlayer.selectedCharacterName), initPos, Quaternion.identity);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
