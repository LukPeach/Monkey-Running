using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script to control player UI.
public class UI : Scenecontoller
{
    public Animator Monkey;
    [SerializeField] Text goldTxt;


    private void Update()
    {
        Displaygold();
    }

    //Slide hp.
    public void Displayhp()
    {
        GetComponent<Slider>().value = Gamemanager.Instance.hp;
    }

    //Slide star.
    public void star()
    {
        GetComponent<Slider>().value = Gamemanager.Instance.star;
    }

    //Slide star map2.
    public void StartLeval2()
    {
        GetComponent<Slider>().value = Gamemanager.Instance.star-3;
    }

    //Text show gold.
    private void Displaygold()
    {
        goldTxt.text = "Gold " + Gamemanager.Instance.gold.ToString();

    }

    //slide load scene.
    public void TimeLoading()
    {
        Gamemanager.Instance.timeSceme =  GetComponent<Slider>().value = 0f + Time.timeSinceLevelLoad / Gamemanager.Instance.timeLoad;
    }
}
