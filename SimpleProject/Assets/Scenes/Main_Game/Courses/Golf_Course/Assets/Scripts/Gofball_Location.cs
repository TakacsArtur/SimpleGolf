using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Gofball_Location : MonoBehaviour
{
    public GameObject golfClub, eventSystem, golfBallParticleEmitterCone, golfBallParticleEmitterSphere, terrainFloor;
    private bool ballHit = false, alreadyWaiting = false; 
   
    float speed = 0;
    Vector3 cmpLocation;
    void Start()
    {
        cmpLocation = transform.position;
        golfBallParticleEmitterCone.GetComponent<ParticleSystem>().Stop();
        golfBallParticleEmitterSphere.GetComponent<ParticleSystem>().Stop();
    }

    void FixedUpdate()
    {
        var currentLocation = transform.position;
        var vectorSpeed = currentLocation - cmpLocation;
        //ultimately movement in any direction is as good as in any other
        speed = vectorSpeed.x + vectorSpeed.y + vectorSpeed.z;
        if(ballHit && Mathf.Abs(speed) < 0.0003 && !alreadyWaiting){
            //we have to wait, to see if the ball changes direction
            alreadyWaiting = true;
            StartCoroutine(WaitAndSeeIfBallChangesDirection());
        }
        cmpLocation = currentLocation;
    }

    IEnumerator WaitAndSeeIfBallChangesDirection(){
        Debug.Log("Waiting and seeing");
        GetComponent<Rigidbody>().useGravity = false;
        yield return new WaitForSeconds(2);
        Debug.Log("Ball too slow, now stopped");
        BallStopped();

        alreadyWaiting = false;
    }

    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == terrainFloor.name){
            golfBallParticleEmitterCone.GetComponent<ParticleSystem>().Stop();
            golfBallParticleEmitterSphere.GetComponent<ParticleSystem>().Stop();
       }
    }

    private IEnumerator smoothChangeToPlayerCamera(){
        yield return new WaitForSeconds(1);
        eventSystem.GetComponent<Gof_Teleport>().TeleportPlayer();
        eventSystem.GetComponent<CameraControl>().showPlayerCamera();
       
    }

    private void BallStopped(){
        //ball is force stopped so that teleport can happen accurately
        StartCoroutine(smoothChangeToPlayerCamera());
        Debug.Log("Ball stopped at" + transform.position);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        ballHit = false;
    }

    public void BallHit()
    {
        golfBallParticleEmitterCone.GetComponent<ParticleSystem>().Play();
         golfBallParticleEmitterSphere.GetComponent<ParticleSystem>().Play();
        GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("Ball hit");
        eventSystem.GetComponent<CameraControl>().showBallCamera();
        StartCoroutine(smoothBallHit());
    }
    //basically the ball gets hit too slowly for the camera change not to trigger
    private IEnumerator smoothBallHit(){
        yield return new WaitForSeconds((float)0.5);
        ballHit = true;
    }
}
