using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsBehavior : MonoBehaviour
{
    /*
        Items tags and details:
            - Coin: only add coin
            - Feather: shield character from debuff
            - Slow Pill: make obstacle move faster
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
                BirdsController.activeEffect = "feather";
                break;

            case "Slow Pill":
                // Faster obstacle
                if (BirdsController.activeEffect != "feather")
                {
                    BirdsController.activeEffect = "pill";
                    TriggerEffect();
                }
                break;

            case "Bomb":
                // Player die
                if (BirdsController.activeEffect != "feather")
                {
                    break;
                }
                break;

            case "Super Power Potion":
                // Feather + remove current effect
                BirdsController.activeEffect = "feather";
                break;

            default:
                break;
        }
    }

    public static void TriggerEffect()
    {
        switch (BirdsController.activeEffect)
        {
            case "pill":
                // reduce obstacle move speed
                break;

            default:
                break;
        }
    }
}
