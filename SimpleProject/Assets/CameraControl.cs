using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject playerCamera, ballCamera, golfClub;
    void Start()
    {
       showPlayerCamera(); 
    }

    public void showPlayerCamera(){
        playerCamera.SetActive(true);
        ballCamera.SetActive(false);
        
        golfClub.GetComponent<MeshRenderer>().enabled = true;
    }

    public void showBallCamera(){
        playerCamera.SetActive(false);
        ballCamera.SetActive(true);

        //this is a practical requirement
        golfClub.GetComponent<MeshRenderer>().enabled = false;
    }
}
