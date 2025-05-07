using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall_Camera : MonoBehaviour
{
    public Transform target;
    public float offsetx, offsety, offsetz;
    void Update()
    {
        transform.position = new Vector3(target.position.x*offsetx, target.position.y*offsety, target.position.z*offsetz);
    }
}
