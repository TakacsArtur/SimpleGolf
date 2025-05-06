using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    }

    public void showBallCamera(){
        playerCamera.SetActive(false);
        ballCamera.SetActive(true);
    }
}
