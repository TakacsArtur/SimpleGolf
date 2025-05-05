using UnityEngine;

public class Gof_Teleport : MonoBehaviour
{
    public GameObject golfBall, player;
    private Rigidbody golfClubRB;
    
    public void TeleportPlayer(){
        player.transform.position = new Vector3(golfBall.transform.position.x, golfBall.transform.position.y + (float)4.5 , golfBall.transform.position.z);
    }
}
