using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to check player's blood collection.
public class HP : Rt
{
    void Update()
    {
        Rotate();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player's blood decreases and collects blood blood will increase by 1.
        if (collision.gameObject.tag == "Player" && Gamemanager.Instance.hp < 5)
        {
            Gamemanager.Instance.hp += 1;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player" && Gamemanager.Instance.hp >= 5)
        {
            Destroy(gameObject);
        }
    }
}
