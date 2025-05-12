using UnityEngine;
using UnityEngine.Timeline;

public class Gof_Teleport : MonoBehaviour
{
    public GameObject golfBall, player, floor, golfBallStand, golfClub, golfBallCamera;
    float robotOffset, golfBallOffset;
    public float golfClubDefaultx, golfClubDefaulty, golfClubDefaultz;
    public float golfBallDefaultx, golfBallDefaulty, golfBallDefaultz;
    public float golfClubPosDefaultx, golfClubPosDefaulty, golfClubPosDefaultz;
    
    private Terrain activeTerrain;

    void Start()
    {
        
        activeTerrain = floor.GetComponent<Terrain>();
        //we are calculating a height offset 
        robotOffset = activeTerrain.SampleHeight(player.transform.position) - player.transform.position.y;
        Debug.Log("Robotoffset: " + robotOffset);
        //this is the height offset from the stand to the ball
        golfBallOffset = activeTerrain.SampleHeight(player.transform.position) - golfBall.transform.position.y;
        Debug.Log(activeTerrain.SampleHeight(player.transform.position));
    }
    public void TeleportPlayer()
    {   
        Debug.Log(activeTerrain.SampleHeight(player.transform.position));
        //Please note, the X/Z (so the two plain axies) are determined by the golfball, (basically the player walks to the ball), but the offset is calculated by the floor
        player.transform.position = new Vector3(golfBall.transform.position.x, activeTerrain.SampleHeight(golfBall.transform.position) - robotOffset , golfBall.transform.position.z);      
        //Set the arm for the teleport, when the ball is nowhere near
        golfClub.transform.localEulerAngles = new Vector3(golfClubDefaultx, golfClubDefaulty, golfClubDefaultz);
        golfClub.transform.localPosition = new Vector3(golfClubPosDefaultx, golfClubPosDefaulty, golfClubPosDefaultz);
        
        golfBall.transform.position = new Vector3(golfBallStand.transform.position.x, activeTerrain.SampleHeight(golfBall.transform.position) - golfBallOffset , golfBallStand.transform.position.z);
        golfBall.transform.localEulerAngles = new Vector3(golfBallDefaultx, golfBallDefaulty, golfBallDefaultz);
    }
}
