using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script control ai.
public class AI : MonoBehaviour
{
    Animator Anmin;
    public Transform Player;
    [SerializeField] float longDistance, DistanceToPlayer, closeDistance;
    SpriteRenderer sr;

    void Start()
    {
        Anmin = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Detectplayer();
        flip();
    }

    //Function check when the player approaches.
    void Detectplayer()
    {
        DistanceToPlayer = Vector2.Distance(Player.position, transform.position);

        //follow the players.
        if (DistanceToPlayer <= longDistance)
        {
            Anmin.SetInteger("AI", 2);
            FollowPlayer();

        }

        //stand and look at the players
        else if (DistanceToPlayer <= closeDistance)
        {
            Anmin.SetInteger("AI", 1);

        }
        else
        {
            Anmin.SetInteger("AI", 0);
        }
    }

    //Function to check the face of AI.
    void flip()
    {
        if (transform.position.x > 0)
        {
            sr.flipX = true;
        }
        if (transform.position.x < 0)
        {
            sr.flipX = false;
        }
    }

    //Function follow the players.
    void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, Gamemanager.Instance.speedAI * Time.deltaTime);
    }

    //Function Gizmos.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, longDistance);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, closeDistance);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Reduces player's health when colliding.
        if (collision.gameObject.tag == "Player")
        {
            Gamemanager.Instance.hp -= Gamemanager.Instance.aiDisHP;
        }

        //Destroyed when falling into a map or water.
        if (collision.gameObject.tag == "ENDGAME")
        {
            Destroy(gameObject);
        }
    }
}
