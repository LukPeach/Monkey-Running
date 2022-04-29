using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to control players.
public class Player : MonoBehaviour
{
    Animator Monkey;
    float Inputx, Inputz;
    Rigidbody2D rb;
    SpriteRenderer sr;
    BoxCollider2D bc;

    bool gameovert = true;
    private bool isJumping = false;

    private AudioSource audioSource;
    bool isMoving = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = transform.GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        Monkey = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {
        gameOver();

        //If the player is not dead, run the function inside.
        if (gameovert)
        {
            MoveAxis();
            flip();
            fire();
            jumped();
        }
        Sound();
    }
    private void FixedUpdate()
    {
        //If the player is not dead, run the function inside.
        if (gameovert)
        {
            MoveWlak();
            Run();
            Slid();
        }
    }

    //GetAxis to variable.
    void MoveAxis()
    {
        Inputx = Input.GetAxis("Horizontal");
        Inputz = Input.GetAxis("Vertical");
    }

    //function character movement.
    void MoveWlak()
    {
        rb.velocity = new Vector3(Inputx * Gamemanager.Instance.speedWalk, rb.velocity.y, Inputz * Gamemanager.Instance.speedWalk);

        //Animation walk.
        Monkey.SetInteger("Player", 1);

        //Animation idel.
        if (Inputx == 0)
        {
            Monkey.SetInteger("Player", 0);
        }
        SoundWalk(); 
    }

    //function character run.
    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector3(Inputx * Gamemanager.Instance.speedRun, rb.velocity.y, Inputz * Gamemanager.Instance.speedRun);

            //Animation run.
            Monkey.SetInteger("Player", 2);
        }
    }

    //function character slid.
    void Slid()
    {
        if (Input.GetButton("Fire2"))
        {
            rb.velocity = new Vector3(Inputx * Gamemanager.Instance.speedSlid, rb.velocity.y, Inputz * Gamemanager.Instance.speedSlid);

            //Animation slid.
            Monkey.SetInteger("Player", 4);
        }
    }

    //function turn of the character.
    void flip()
    {
        if (Inputx < 0)
        {
            sr.flipX = true;
        }
        if (Inputx > 0)
        {
            sr.flipX = false;
        }
    }

    //function character jump.
    void jumped()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {

            //Animation jump.
            Monkey.SetInteger("Player", 3);
            rb.AddForce(Vector2.up * Gamemanager.Instance.jumpHeight);
            isJumping = true;
            SoundJump();
        }
    }

    //function flamethrower character.
    void fire()
    {
        if (Input.GetButton("Fire1"))
        {
            //Animation flamethrower.
            Monkey.SetInteger("Player", 5);
        }

    }

    //function check when a player walks into an item and has a sound.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Gold);
        }
        if (collision.gameObject.tag == "Gas")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Hp);
        }
        if (collision.gameObject.tag == "Fier")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Hp);
        }
        if (collision.gameObject.tag == "HP")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Pog);
        }
        if (collision.gameObject.tag == "Star")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Star);
        }
        if (collision.gameObject.tag == "Door")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Next);
        }
        if (collision.gameObject.tag == "Bonus")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Bonus);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks when a player jumps.
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }

        //Check when the player hits the AI.
        if (collision.gameObject.tag == "AI")
        {
            audioSource.PlayOneShot(SoundManager.Instance.Hp);
        }

    }

    //Function check when a player runs out of blood.
    void gameOver()
    {
        if (Gamemanager.Instance.hp <= 0)
        {
            gameovert = false;
        }
    }

    //Function Sound.
    void Sound()
    {
        SoundManager.Instance.soundMusic = false;
    }

    //Function SoundJump.
    void SoundJump()
    {
        audioSource.PlayOneShot(SoundManager.Instance.Jump);
    }

    //Function SoundWalk.
    void SoundWalk()
    {
        if (rb.velocity.x != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(SoundManager.Instance.Walk);
                audioSource.volume = Random.Range(0.1f, 0.3f);
            }

        }
        else
        {
            audioSource.Stop();
        }
    }
}
