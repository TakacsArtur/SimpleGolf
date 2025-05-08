using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GolfBall_Camera : MonoBehaviour
{
    public Transform target, rotationTarget;
    private Vector3 startPosition, secondPosition, direction;
    private bool movementVectoralculated = false;

    public float heightoffset;

    void Start(){
        startPosition = target.transform.position;
    }
    void Update()
    {        

        transform.RotateAround(rotationTarget.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime*10);

        if(movementVectoralculated){
            transform.position = new Vector3(target.transform.position.x - direction.x, target.transform.position.y+heightoffset, target.transform.position.z - direction.z);
        }
    }

   public void ActivateOffset(){
        Debug.Log("Offset activated");
        startPosition = target.transform.position;
        StartCoroutine(waitForBall());
    }

    IEnumerator waitForBall(){
        yield return new WaitForSeconds((float)0.3);
        secondPosition = target.transform.position;

        direction = secondPosition - startPosition;
        movementVectoralculated = true;
    }

    public void DeActivateOffset(){
        Debug.Log("Offset deactivated");
        movementVectoralculated = false;
    }
}
