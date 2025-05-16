using System;
using UnityEngine;

public class EventTriggerScipts : MonoBehaviour
{
    public EventTriggerScipts singletoninstance;
    private void Awake()
    {
        singletoninstance = this;
    }

    //Events in relation to ball position and player position

    public event Action BallLaunched;
    public void BallHasLaunched()
    {
        if (BallLaunched != null)
            BallLaunched();
        Debug.Log("Ball has launched");
    }

    public event Action BallLanded;
    public void BallHasLanded()
    {
        if (BallLanded != null)
            BallLanded();

        Debug.Log("Ball has launched");
    }

    public event Action PlayerTeleported;
    public void PlayerHasTeleported()
    {
        if (PlayerTeleported != null)
            PlayerTeleported();
        Debug.Log("Player was teleported");
    }


    //Events in connection with staging and prestaging

    public event Action StartStage;
    public void OnStartStage()
    {
        if (StartStage != null)
            StartStage();
        Debug.Log("StartStage");
    }

     public event Action PreStage;
    public void OnPreStage()
    {
        if (PreStage != null)
            PreStage();
        Debug.Log("PreStage");
    }
}
