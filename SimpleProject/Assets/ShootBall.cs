using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject golfBall, directionProvider;
    private float golfForcexOffset, golfForceyOffset, golfForcezOffset;

    public enum batType {theBigDriver, putter}

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
            golfForcexOffset = 65;
            golfForceyOffset = 3;
            golfForcezOffset = 65;
        }

        Debug.Log("Current heading:" + directionProvider.transform.forward);

        rb.AddForce(directionProvider.transform.forward.x * golfForcexOffset , directionProvider.transform.forward.y *golfForceyOffset, directionProvider.transform.forward.z * golfForcezOffset);
    }

}
