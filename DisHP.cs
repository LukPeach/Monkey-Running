using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script checks the player's blood being reduced.
public class DisHP : Rt
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamemanager.Instance.hp -= 1;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "AI")
        {
            Destroy(gameObject);
        }
    }
}
