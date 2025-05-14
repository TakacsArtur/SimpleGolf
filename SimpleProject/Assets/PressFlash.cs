using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PressFlash : MonoBehaviour
{
    public GameObject presstext;
    private TMP_Text text;
    public float flashOffset; 
    // Start is called before the first frame update
    void Start()
    {
        text = presstext.GetComponent<TMP_Text>();
        StartCoroutine(FlashText());
    }

    IEnumerator FlashText(){
        while (true){
            yield return new WaitForSeconds(flashOffset);
            text.enabled = false;
            yield return new WaitForSeconds(flashOffset);
            text.enabled = true;
        }
    }
}
