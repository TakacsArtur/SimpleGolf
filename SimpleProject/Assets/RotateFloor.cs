using UnityEngine;

public class RotateFloor : MonoBehaviour
{
    public GameObject floor;
    void FixedUpdate()
    {
        floor.transform.RotateAround(transform.position, new Vector3(0, -1*Input.GetAxis("Horizontal")*100, 0), Time.deltaTime*10);
    }
}
