using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scripts SoundManager get values from inspector.
public class SoundManager : Singleto<SoundManager>
{
    public bool soundMusic;
    [SerializeField] private AudioClip clickBT;
    [SerializeField] private AudioClip clickout;
    [SerializeField] private AudioClip bonus;
    [SerializeField] private AudioClip gold;
    [SerializeField] private AudioClip hp;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip next;
    [SerializeField] private AudioClip over;
    [SerializeField] private AudioClip pog;
    [SerializeField] private AudioClip star;
    [SerializeField] private AudioClip walk;
    [SerializeField] private AudioClip walter;
    [SerializeField] private AudioClip win;

    public static SoundManager Instan
    {
        get;
        private set;
    }
    public AudioClip ClickBT
    {
        get
        {
            return clickBT;
        }
    }
    public AudioClip ClickOut
    {
        get
        {
            return clickout;
        }
    }
    public AudioClip Bonus
    {
        get
        {
            return bonus;
        }
    }
    public AudioClip Gold
    {
        get
        {
            return gold;
        }
    }
    public AudioClip Hp
    {
        get
        {
            return hp;
        }
    }
    public AudioClip Jump
    {
        get
        {
            return jump;
        }
    }
    public AudioClip Next
    {
        get
        {
            return next;
        }
    }
    public AudioClip Over
    {
        get
        {
            return over;
        }
    }
    public AudioClip Pog
    {
        get
        {
            return pog;
        }
    }
    public AudioClip Star
    {
        get
        {
            return star;
        }
    }
    public AudioClip Walk
    {
        get
        {
            return walk;
        }
    }
    public AudioClip Walter
    {
        get
        {
            return walter;
        }
    }
    public AudioClip Win
    {
        get
        {
            return win;
        }
    }
}
