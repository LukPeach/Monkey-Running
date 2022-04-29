using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script fire ball.
public class BirdBall : MonoBehaviour
{
    Rigidbody2D rb2;
    bool checkshoot = true;
    public GameObject bridBall;
    public Transform birdPos;
    public float ballSpeed;
    public float num1 = 5;
    public float num2 = 2;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(checkshoot)
        {
            shoot();
            checkshoot = false;
        }
    }
    void Update()
    {
        //Fireball Drop Cooldown.
        num1 -= Time.deltaTime;
        if (num1 <= 1)
        {
            checkshoot = true;
            num1 = 5 - num2;
        }
    }

    //The function generates a ball of fire from the bird's body.
    private void shoot()
    {
        GameObject BULLET = Instantiate(bridBall, birdPos.position, (bridBall.transform.rotation));
        BULLET.GetComponent<Rigidbody2D>().velocity = new Vector2(0,ballSpeed);
    }
}
