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

        if(ballHit && Mathf.Abs(speed) < 0.0056){
            ballHit = false;
            StartCoroutine(smoothChangeToPlayerCamera());
        }

        cmpLocation = currentLocation;
    }

    private IEnumerator smoothChangeToPlayerCamera(){
        yield return new WaitForSeconds(1);
        eventSystem.GetComponent<CameraControl>().showPlayerCamera();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == golfClub.name){
            eventSystem.GetComponent<CameraControl>().showBallCamera();
            ballHit = true;
        }
    }
}
