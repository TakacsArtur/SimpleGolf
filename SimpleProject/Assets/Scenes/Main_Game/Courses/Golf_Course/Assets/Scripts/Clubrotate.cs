using System;
using UnityEngine;

public class Clubrotate : MonoBehaviour
{
    public int rotationMultiplier = 1;
    public GameObject rotationAxis;
    public float speedmultiplier = 25;
    private bool ignoreInput = true;

    // Update is called once per frame

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            ignoreInput = false;
        }
    }
    void FixedUpdate()
    {    
        if(!ignoreInput){
            transform.RotateAround(rotationAxis.transform.position, rotationMultiplier * Input.GetAxis("Vertical") * -1 * transform.right, Time.deltaTime*speedmultiplier);
        }
    }

    public void resetIgnoreInput()
    {
        ignoreInput = true;
    }
}
