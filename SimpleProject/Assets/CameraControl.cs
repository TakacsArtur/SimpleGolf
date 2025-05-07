
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject golfClub;
    public Camera playerCamera, ballCamera;
    public AudioListener playerListener, ballListener;
    void Start()
    {

       showPlayerCamera(); 
    }

    public void showPlayerCamera(){
        playerCamera.enabled = true;
        playerListener.enabled = true;

        ballCamera.GetComponent<GolfBall_Camera>().DeActivateOffset();
        ballCamera.enabled = false;
        ballListener.enabled = false;
    }

    public void showBallCamera(){
        playerCamera.enabled = false;
        playerListener.enabled = false;


        ballCamera.GetComponent<GolfBall_Camera>().ActivateOffset();
        ballCamera.enabled = true;
        ballListener.enabled = true;
    }
}
