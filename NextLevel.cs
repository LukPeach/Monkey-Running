using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script check when a player walks through the door.
public class NextLevel : Scenecontoller
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            PlaytoL2();
        }
        if (collision.gameObject.tag == ("Player"))
        {
            Winer();
        }
    }
}
