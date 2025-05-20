using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThankYouScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CloseApp());
    }

    IEnumerator CloseApp()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();   
    }
}
