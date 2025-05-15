using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerScipts : MonoBehaviour
{
    public EventTriggerScipts singletoninstance;
    private void Awake()
    {
        singletoninstance = this;
    }

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
}
