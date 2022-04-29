using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script check when a player hits a fireball.
public class FireBall : MonoBehaviour
{
    float num = 2;
    void Update()
    {
        num -= Time.deltaTime;
        if(num <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player is hit by fire, the blood will decrease.
        if (collision.gameObject.tag == ("Player"))
        {
            Gamemanager.Instance.hp -= Gamemanager.Instance.fierBall;
        }
    }

}
