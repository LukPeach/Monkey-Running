using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script checks the player walking into the bonus door.
public class DoorBonus : Scenecontoller
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            BonusScene();
            Gamemanager.Instance.doorBonus += 1;
            Destroy(gameObject);
        }
    }
}
