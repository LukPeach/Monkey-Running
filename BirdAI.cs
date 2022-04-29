using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script control BirdAI.
public class BirdAI : MonoBehaviour
{
    bool check = true;
    SpriteRenderer sr;
    public int speedBird;
    public float deltaBird;
    float deltaBird2;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        deltaBird2 = deltaBird;
    }
    private void Update()
    {
        if(check == true)
        {
            transform.Translate(new Vector2(1 * Time.deltaTime * speedBird, 0));
            deltaBird -= Time.deltaTime;
        }
        if(deltaBird <= 0)
        {
            check = false;
        }
        if(check ==false)
        {
            transform.Translate(new Vector2(-1 * Time.deltaTime * speedBird, 0));
            deltaBird += Time.deltaTime;
        }
        if (deltaBird >= deltaBird2)
        {
            check = true;
        }
        flip();
    }

    //Function to check the face of BirdAI.
    void flip()
    {
        if (check == false)
        {
            sr.flipX = true;
        }
        if (check == true)
        {
            sr.flipX = false;
        }
    }
}
