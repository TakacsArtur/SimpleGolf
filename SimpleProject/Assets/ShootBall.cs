using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class ShootBall : MonoBehaviour
{
    public GameObject golfBall;
    public float golfForcexOffset, golfForceyOffset, golfForcezOffset;
    Rigidbody rb;
    void Start()
    {
        rb = golfBall.GetComponent<Rigidbody>();
    }

     void OnTriggerEnter()
    {   
        golfBall.GetComponent<Gofball_Location>().BallHit();
        rb.AddForce(golfBall.transform.forward.x * golfForcexOffset , golfBall.transform.forward.y + golfForceyOffset, golfBall.transform.forward.z * golfForcezOffset);
    }


}
