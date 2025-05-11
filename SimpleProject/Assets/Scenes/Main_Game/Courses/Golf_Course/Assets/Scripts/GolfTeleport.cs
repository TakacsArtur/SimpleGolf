using Unity.VisualScripting;
using UnityEngine;

public class GolfTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerDeadInstance, playerLiveInstance, golfBall, floor;
    void Start()
    {
        playerDeadInstance.SetActive(false);
        Debug.Log(GameObject.Find("GolfBallStand").GetComponent<Renderer>().bounds.size);
        
    }

    // Update is called once per frame
    public void GenerateNewPlayer()
    {
        Destroy(playerLiveInstance);
        playerLiveInstance = GameObject.Instantiate(playerDeadInstance);
        playerLiveInstance.transform.position = new Vector3(golfBall.transform.position.x, golfBall.transform.position.y, golfBall.transform.position.z);
        playerLiveInstance.SetActive(true);
        golfBall.transform.position = new Vector3(golfBall.transform.position.x, golfBall.transform.position.y + (float)(-0.43), golfBall.transform.position.z);
    }
}