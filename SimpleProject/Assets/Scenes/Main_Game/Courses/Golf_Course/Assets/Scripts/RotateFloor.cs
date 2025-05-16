using UnityEngine;

public class RotateFloor : MonoBehaviour
{
    public GameObject axis, eventSystem;
    private bool ballHit = false;

    void FixedUpdate()
    {
        if (IsRotable())
        {
            transform.RotateAround(axis.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime * 10);
        }
    }

    void Start()
    {
        eventSystem.GetComponent<EventTriggerScipts>().BallLaunched += BallHit;
        eventSystem.GetComponent<EventTriggerScipts>().PlayerTeleported += BallStopped;
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
            return false;
        }

        return true;
    }
}
