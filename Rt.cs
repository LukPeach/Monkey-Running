using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to rotate objects in the game.
public class Rt : MonoBehaviour
{
    public void Rotate()
    {
        transform.Rotate(new Vector2(0, Gamemanager.Instance.rtspeed));
    }
}
