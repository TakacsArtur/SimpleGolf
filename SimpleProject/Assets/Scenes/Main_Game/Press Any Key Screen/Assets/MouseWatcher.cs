using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseWatcher : MonoBehaviour
{
    public string NextScene;
    public AudioSource Sound;
    private bool alreadyOpened = false;
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && !alreadyOpened)
        {
            alreadyOpened = true;
            StartCoroutine(LoadNextSceneSmoothly());
        }
    }

    IEnumerator LoadNextSceneSmoothly(){
        Sound.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(NextScene);
    }
}
