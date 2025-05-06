using System;
using System.Collections;
using UnityEngine;

public class Gofball_Location : MonoBehaviour
{
    public GameObject golfClub, eventSystem;
    private bool ballHit = false;
    float speed = 0;
    Vector3 cmpLocation;
    void Start()
    {
        cmpLocation = transform.position;
    }

    void FixedUpdate()
    {
        var currentLocation = transform.position;
        var vectorSpeed = currentLocation - cmpLocation;
        //ultimately movement in any direction is as good as in any other
        speed = vectorSpeed.x + vectorSpeed.y + vectorSpeed.z;
        if(ballHit && Mathf.Abs(speed) < 0.0010){
            Debug.Log("Ball too slow, now stopped");
            BallStopped();
        }
        cmpLocation = currentLocation;
    }


    private IEnumerator smoothChangeToPlayerCamera(){
        yield return new WaitForSeconds(1);
        eventSystem.GetComponent<Gof_Teleport>().TeleportPlayer();
        eventSystem.GetComponent<CameraControl>().showPlayerCamera();
       
    }

    private void BallStopped(){
        //ball is force stopped so that teleport can happen accurately
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        StartCoroutine(smoothChangeToPlayerCamera());
        Debug.Log("Ball stopped at" + transform.position);
        ballHit = false;
    }

    public void BallHit()
    {
        Debug.Log("Ball hit");
        eventSystem.GetComponent<CameraControl>().showBallCamera();
        StartCoroutine(smoothBallHit());
        GetComponent<Rigidbody>().AddForce(new Vector3(30, 30, 10));
    }
    //basically the ball gets hit too slowly for the camera change not to trigger
    private IEnumerator smoothBallHit(){
        yield return new WaitForSeconds((float)0.5);
        ballHit = true;
    }
}
