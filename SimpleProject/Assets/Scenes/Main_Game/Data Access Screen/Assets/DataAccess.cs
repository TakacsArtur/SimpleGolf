using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataAccess : MonoBehaviour
{
    public string SceneName, UnloadTitle, UnloadStart;

    void Start()
    {
        StartCoroutine(LoadGameScene());
    }
    IEnumerator LoadGameScene()
    {
       
        AsyncOperation loadGame = SceneManager.LoadSceneAsync(SceneName);
        AsyncOperation unloadTitle = SceneManager.UnloadSceneAsync(UnloadTitle);
        AsyncOperation uploadStart = SceneManager.UnloadSceneAsync(UnloadStart);
        yield return null;
    }
}
