using System.Collections;
using UnityEngine;

public class PutterSelect : MonoBehaviour
{
    private bool isRightDirection;
    public GameObject Club;
    private bool onStartStage;
    void Start()
    {
        GetComponent<EventTriggerScipts>().PreStage += setPreStage;
        GetComponent<EventTriggerScipts>().StartStage += setStartStage;   
    }
    public void HoldTheButton()
    {
        if (onStartStage)
        {
            Debug.Log("Button holding");
            StartCoroutine(WaitForABit());
        }
    }

    IEnumerator WaitForABit()
    {

        yield return new WaitForSeconds(1);
        Club.GetComponent<ShootBall>().SelectPutter(isRightDirection);
        Debug.Log("Changed Bat");
    }

    public void setRightDirection()
    {
        isRightDirection = true;
    }

    public void SetLeftDirection()
    {
        isRightDirection = false;
    }

    public void setStartStage()
    {
        onStartStage = true;
    }

    public void setPreStage()
    {
        //Putter changing is only allowed at the startstate 
        onStartStage = false;
    }
}
