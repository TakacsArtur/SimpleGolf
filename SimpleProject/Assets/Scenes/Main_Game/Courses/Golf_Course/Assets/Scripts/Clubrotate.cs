using UnityEngine;

public class Clubrotate : MonoBehaviour
{
    public int rotationMultiplier = 1;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.maxAngularVelocity = float.MaxValue;
        rb.AddTorque(rotationMultiplier * Input.GetAxis("Vertical")* -1 *Vector3.forward);
    }
}
