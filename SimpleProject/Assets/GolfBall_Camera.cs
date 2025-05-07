using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GolfBall_Camera : MonoBehaviour
{
    public Transform target, rotationTarget;
    public float offsetx, offsety, offsetz;
    private float correctedOffsetx, correctedOffsety, correctedOffsetz;
    void Update()
    {
        
        transform.position = new Vector3(target.position.x+correctedOffsetx, target.position.y+correctedOffsety, target.position.z+correctedOffsetz);
        transform.RotateAround(rotationTarget.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime*10);
    }

   public void ActivateOffset(){
        Debug.Log("Offset activated");
        correctedOffsetx = offsetx;
        correctedOffsety = offsety;
        correctedOffsetz = offsetz;
    }

    public void DeActivateOffset(){
        Debug.Log("Offset deactivated");
        correctedOffsetx =0;
        correctedOffsety =0;
        correctedOffsetz =0;
    }
}
