using System.Collections;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject golfBall, directionProvider;
    private float golfForcexOffset, golfForceyOffset, golfForcezOffset;

    public enum batType {theBigDriver, putter, medDriver}

    public batType currentBat;
    Rigidbody rb;
    void Start()
    {
        rb = golfBall.GetComponent<Rigidbody>();
    }

     void OnTriggerEnter()
    {   
        golfBall.GetComponent<Gofball_Location>().BallHit();
        Debug.Log("Ball was hit");
        LaunchBall(currentBat);
    }

    void LaunchBall(batType currentBat){
        
        if (currentBat == batType.putter){
            golfForcexOffset = 3;
            golfForceyOffset = 0;
            golfForcezOffset = 3;
        }

        if (currentBat == batType.theBigDriver){
            golfForcexOffset = 12;
            golfForceyOffset = 3;
            golfForcezOffset = 12;

        }

        if(currentBat == batType.medDriver){
            golfForcexOffset = 5;
            golfForceyOffset = 0.5F;
            golfForcezOffset = 5;

        }

        Debug.Log("Current heading:" + directionProvider.transform.forward);
        Debug.Log("Selected battype" + currentBat);
        rb.AddForce(directionProvider.transform.forward.x * golfForcexOffset , directionProvider.transform.forward.y + golfForceyOffset, directionProvider.transform.forward.z * golfForcezOffset, ForceMode.Impulse);
    }

    public void SetCurrentBat(batType bat){
        currentBat = bat;
    }

    public batType GetCurrentBat(){
        return currentBat;
    }

}
