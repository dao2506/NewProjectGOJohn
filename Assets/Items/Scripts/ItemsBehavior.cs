using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsBehavior : MonoBehaviour
{
    /*
        Items tags and details:
            - Coin: only add coin
            - Feather: shield character from debuff
            - Slow Pill: slow down move speed and jump force
            - Bomb: Instantly destroy character
            - Super Power Potion: effect from feather + slow down obstacle
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    public static void TriggerItem(string item)
    {
        switch (item)
        {
            case "Coin":
                // Add 1 coin
                BirdsController.numCoin += 1;
                Debug.Log("hit coin");
                break;

            case "Feather":
                // Shield player from 1 debuff
                break;

            case "Slow Pill":
                // Faster obstacle
                break;

            case "Bomb":
                // Player die
                break;

            case "Super Power Potion":
                // Feather + slow down obstacle
                break;

            default:
                break;
        }
    }
}
