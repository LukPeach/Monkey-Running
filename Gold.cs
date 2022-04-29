using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script checks players collect gold.
public class Gold : Rt
{
    private void Update()
    {
        Rotate();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamemanager.Instance.gold += 1;
            Destroy(gameObject);
        }
    }
}
