using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutterZone : MonoBehaviour
{
    public GameObject Club;

    void OnTriggerEnter(Collider other)
    {
        Club.GetComponent<ShootBall>().setPutterZone();
        Debug.Log("Putterzone entered");
    }

    void OnTriggerExit(Collider other)
    {
        Club.GetComponent<ShootBall>().reSetInPutterZone();
        Debug.Log("Putterzone exited");
    }
}
