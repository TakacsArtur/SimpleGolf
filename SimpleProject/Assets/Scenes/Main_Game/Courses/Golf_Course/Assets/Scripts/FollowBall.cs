using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball, rotationTarget;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotationTarget.transform.position, new Vector3(0, Input.GetAxis("Horizontal"), 0), Time.deltaTime*10);
        transform.position = ball.transform.position;
    }
}
