using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Clubrotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotationMultiplier = 1;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.maxAngularVelocity = float.MaxValue;
        rigidbody.AddTorque(rotationMultiplier * Input.GetAxis("Vertical")* -1 *Vector3.forward);
        
    }
}
