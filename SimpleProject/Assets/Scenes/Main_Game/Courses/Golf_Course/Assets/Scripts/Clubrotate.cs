using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Clubrotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotationMultiplier = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationMultiplier * Input.GetAxis("Vertical") * -1*Vector3.forward, Space.World);
    }
}
