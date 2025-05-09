using TMPro;
using UnityEngine;

public class ScreCounter : MonoBehaviour
{
    public GameObject ScoreDisplay;
    double score = 0;

    public void Start()
    {
        ScoreDisplay.GetComponent<TMP_Text>().text = "Score: " + score;
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

        ScoreDisplay.GetComponent<TMP_Text>().text = "Score: " + score;
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
