using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Animations;

public class Clubrotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotationMultiplier = 1;
    public int tankMultiplier = 1;
    public float maxRotationAngle, minRotationAngle;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.maxAngularVelocity = float.MaxValue;
        rb.AddTorque(rotationMultiplier * Input.GetAxis("Vertical")* -1 *Vector3.forward);
    }
}
