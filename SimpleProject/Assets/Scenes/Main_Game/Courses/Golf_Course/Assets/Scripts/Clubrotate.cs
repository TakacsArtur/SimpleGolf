using System;
using UnityEngine;

public class Clubrotate : MonoBehaviour
{
    public int rotationMultiplier = 1;
    public GameObject rotationAxis;
    public float speedmultiplier = 500;

    // Update is called once per frame
    void FixedUpdate()
    {    
        transform.RotateAround(rotationAxis.transform.position, rotationMultiplier * Input.GetAxis("Vertical") * -1 * transform.right, Time.deltaTime*speedmultiplier);   
    }
}
