using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataAccess : MonoBehaviour
{
    public string SceneName;

    void Start()
    {
        StartCoroutine(LoadGameScene());
    }
    IEnumerator LoadGameScene()
    {
       
        AsyncOperation loadGame = SceneManager.LoadSceneAsync(SceneName);
        yield return null;
    }
}
