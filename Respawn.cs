using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script checks when the player falls on the map or in the water.
public class Respawn : MonoBehaviour
{
    [SerializeField] Animator player;
    [SerializeField] Animator respawn;
    private void Update()
    {
        Respawnn();
    }
    void Respawnn()
    {
        Vector3 Falling = player.GetComponent<Transform>().position;
        Vector3 Falling1 = respawn.GetComponent<Transform>().position;
    }

    //When the player falls on the map or the water removes hp 2.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = respawn.transform.position;
            Gamemanager.Instance.hp -= 2;
        }
    }
}
