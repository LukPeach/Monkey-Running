using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The script controls the scene in the game.
public class Scenecontoller : MonoBehaviour
{
    //Function scene one load and reset.
    public void LoadSceneName(string scencename)
    {
        SceneManager.LoadScene(scencename);
        Gamemanager.Instance.sound += 1;
        Gamemanager.Instance.hp += 5;
        Gamemanager.Instance.star = 0;
        Gamemanager.Instance.gold = 0;
    }

    //Function scene two load and reset.
    public void LoadSceneName1(string scencename)
    {
        if (Gamemanager.Instance.door >= 1)
        {
            SceneManager.LoadScene(scencename);
            Gamemanager.Instance.star = 3;
            Gamemanager.Instance.hp += 5;
            Gamemanager.Instance.gold = 0;
        }
    }    
    private void Update()
    {
        GameOver();
    }

    //Check the players to Stage 2.
    public void PlaytoL2()
    {
        if(Gamemanager.Instance.star ==3)
        {
            Gamemanager.Instance.door += 1;
            SceneManager.LoadScene("Loadscene");
        }
    }

    //check player wins.
    public void Winer()
    {
        if(Gamemanager.Instance.star ==8)
        {
            SceneManager.LoadScene("Win");
        }
    }

    //check the loser.
    public void GameOver()
    {
        if (Gamemanager.Instance.hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Gamemanager.Instance.hp += 5;
        }
    }
    public void LoadScene()
    {
        if(Gamemanager.Instance.timeSceme >= 1)
        {
            SceneManager.LoadScene("L2");
        }
    }

    //Check the players to the bonus scene.
    public void BonusScene()
    {
        SceneManager.LoadScene("Bonus");
        if(Gamemanager.Instance.doorBonus == 1)
        {
            SceneManager.LoadScene("L2.2");
        }
    }

}
