using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFloor : MonoBehaviour
{
    public GameObject rotationAxis;
    void FixedUpdate()
    {
        transform.RotateAround(rotationAxis.transform.position, new Vector3(0, -1*Input.GetAxis("Horizontal")*100, 0), Time.deltaTime*10);
    }
}
