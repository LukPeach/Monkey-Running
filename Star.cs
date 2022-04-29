using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script checks players approaching the stars.
public class Star : Rt
{
    private void Update()
    {
        Rotate();
    }

    //send star value to Gamemanager.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamemanager.Instance.star += 1;
            Destroy(gameObject);
        }
    }
}
