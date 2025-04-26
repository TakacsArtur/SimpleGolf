using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall_Camera : MonoBehaviour
{
    public Transform target;
    public float offsetx, offsety, offsetz;
    void Update()
    {
        //lock rotation
        Vector3 eulerAngles = transform.eulerAngles;
		transform.eulerAngles = new Vector3(0 , 270 , 0);

        transform.position = new Vector3(target.position.x*offsetx, target.position.y*offsety, target.position.z*offsetz);

        Debug.Log(transform.position);
    }
}
