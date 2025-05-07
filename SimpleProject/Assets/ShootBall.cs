using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject golfBall;
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
        LaunchBall(currentBat);
    }

    void LaunchBall(batType currentBat){
        
        if (currentBat == batType.putter)
            golfForcexOffset

        rb.AddForce(golfBall.transform.forward.x * golfForcexOffset , golfBall.transform.forward.y + golfForceyOffset, golfBall.transform.forward.z * golfForcezOffset);
    }

}
