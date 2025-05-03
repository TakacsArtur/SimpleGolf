using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerDeadInstance;
    void Start()
    {
      playerDeadInstance.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
