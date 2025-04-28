using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject playerCamera, ballCamera;
    void Start()
    {
       showPlayerCamera(); 
    }

    public void showPlayerCamera(){
        playerCamera.SetActive(true);
        ballCamera.SetActive(false);
    }

    public void showGameCamera(){
        playerCamera.SetActive(false);
        ballCamera.SetActive(true);
    }


}
