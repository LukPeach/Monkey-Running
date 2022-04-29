using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scripts control variables in the game.
public class Gamemanager : Singleto<Gamemanager>
{
    public int gold;
    public int speedWalk;
    public int speedRun;
    public int speedSlid;
    public float jumpHeight;
    public int rtspeed;
    public int hp;
    public int aiDisHP;
    public int speedAI;
    public int star;
    public float timeLoad;
    public float timeSceme;
    public int doorBonus;
    public int fierBall;
    public int sound;
    public int door;
    private void Awake()
    {
        gold = 0;
        hp = 5;
        star = 0;

    }
    private void Update()
    {
        if(hp <=0)
        {
            hp = 0;
        }
        if(hp >5)
        {
            hp = 5;
        }
    }
}
