using UnityEngine;

public class Gof_Teleport : MonoBehaviour
{
    public GameObject golfBall, player, floor, golfBallStand, golfClub, golfBallCamera;
    float robotOffset, golfBallOffset;
    public float golfClubDefaultx, golfClubDefaulty, golfClubDefaultz;
    public float golfBallDefaultx, golfBallDefaulty, golfBallDefaultz;
    public float golfClubPosDefaultx, golfClubPosDefaulty, golfClubPosDefaultz;
    

    void Start()
    {
        //we are calculating a height offset 
        robotOffset = floor.transform.position.y - player.transform.position.y;
        Debug.Log("Robotoffset: " + robotOffset);
        //this is the height offset from the stand to the ball
        golfBallOffset = floor.transform.position.y - golfBall.transform.position.y;

    }
    public void TeleportPlayer()
    {   
        //Please note, the X/Z (so the two plain axies) are determined by the golfball, (basically the player walks to the ball), but the offset is calculated by the floor
        player.transform.position = new Vector3(golfBall.transform.position.x, floor.transform.position.y - robotOffset , golfBall.transform.position.z);      
        //Set the arm for the teleport, when the ball is nowhere near
        golfClub.transform.localEulerAngles = new Vector3(golfClubDefaultx, golfClubDefaulty, golfClubDefaultz);
        golfClub.transform.localPosition = new Vector3(golfClubPosDefaultx, golfClubPosDefaulty, golfClubPosDefaultz);
        
        golfBall.transform.position = new Vector3(golfBallStand.transform.position.x, floor.transform.position.y - golfBallOffset , golfBallStand.transform.position.z);
        golfBall.transform.localEulerAngles = new Vector3(golfBallDefaultx, golfBallDefaulty, golfBallDefaultz);
    }
}
