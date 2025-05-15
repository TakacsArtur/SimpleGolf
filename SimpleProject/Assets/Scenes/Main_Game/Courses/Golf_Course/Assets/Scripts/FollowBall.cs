using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball, rotationTarget, eventSystem;
    private bool ballHit = false;
    // Update is called once per frame  
    void Update()
    {
        if (IsRotable())
        {
            transform.RotateAround(rotationTarget.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime * 10);
        }
        transform.position = ball.transform.position;
    }

    void Start()
    {
        eventSystem.GetComponent<EventTriggerScipts>().BallLaunched += BallHit;
        eventSystem.GetComponent<EventTriggerScipts>().BallLanded += BallStopped;
    }
    
     void BallStopped()
    {
        ballHit = false;
        Debug.Log("Ball stopped");
    }

    void BallHit()
    {
        ballHit = true;
        Debug.Log("Ball shot");
    }

    bool IsRotable()
    {
        if (ballHit == true)
        {
            Debug.Log("Ballhit" + ballHit);
            return false;
        }

        return true;
    }
}
