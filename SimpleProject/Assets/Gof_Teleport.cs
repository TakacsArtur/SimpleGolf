using UnityEngine;

public class Gof_Teleport : MonoBehaviour
{
    public GameObject golfBall, player, golfClub;
    private Rigidbody golfClubRB;
    void Start()
    {
        golfClubRB = golfClub.GetComponent<Rigidbody>();
        player.transform.position = new Vector3(0,0,0);
        golfClubRB.MovePosition(new Vector3(0,0,0));
    }

    
    public void TeleportPlayer(){
        Vector3 offset = player.transform.position - golfBall.transform.position;
        player.transform.position = new Vector3(golfBall.transform.position.x, golfBall.transform.position.y + (float)4.5 , golfBall.transform.position.z);
        golfClubRB.transform.position = offset;
    }
}
