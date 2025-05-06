using UnityEngine;

public class RotateFloor : MonoBehaviour
{
    public GameObject axis;
    void FixedUpdate()
    {
        transform.RotateAround(axis.transform.position, new Vector3(0, -1*Input.GetAxis("Horizontal")*100, 0), Time.deltaTime*10);
    }
}
