using System;
using TMPro;
using UnityEngine;

public class ScreCounter : MonoBehaviour
{
    public GameObject ScoreDisplay, HoleName;
    int score = 0;
    public int par;
    public String holename;
    public void Start()
    {
        updateDisplay(score, par);
    }
    public void ballHit()
    {
        if (score<=10){
            addNormalScore();
        }
        else{
            addPenalty();
            GetComponent<GameControl>().LoseGame();
        }

        updateDisplay(score, par);
    }

    private void updateDisplay(int score, int par){
        ScoreDisplay.GetComponent<TMP_Text>().text = "Strokes: " + score + " Par: " + par;
        HoleName.GetComponent<TMP_Text>().text = holename;

    }   

    void addNormalScore()
    {
        score +=1;
    }

    void addPenalty()
    {
        score +=2;
    }
}
