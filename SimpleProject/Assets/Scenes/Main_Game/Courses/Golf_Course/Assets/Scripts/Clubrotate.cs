using System;
using UnityEngine;

public class Clubrotate : MonoBehaviour
{
    public int rotationMultiplier = 1;
    public GameObject rotationAxis, eventSystem;
    public float speedmultiplier = 25;
    private bool preStage = true;

    // Update is called once per frame

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            preStage = false;
            eventSystem.GetComponent<EventTriggerScipts>().OnPreStage();
        }
    }
    void FixedUpdate()
    {    
        if(!preStage){
            transform.RotateAround(rotationAxis.transform.position, rotationMultiplier * Input.GetAxis("Vertical") * -1 * transform.right, Time.deltaTime*speedmultiplier);
        }
    }

    public void resetIgnoreInput()
    {
        preStage = true;
    }
}
