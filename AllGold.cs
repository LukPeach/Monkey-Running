using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script showing gold in game.
public class AllGold : MonoBehaviour
{
    [SerializeField] Text allgoldTxt;

    private void Update()
    {
        AllGoldtogame();
    }
    private void AllGoldtogame()
    {
        allgoldTxt.text = " Gold " + Gamemanager.Instance.gold.ToString();
    }
}
