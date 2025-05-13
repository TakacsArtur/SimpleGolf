using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneMove : MonoBehaviour
{
    public String sceneName;
    void Start()
    {
        StartCoroutine(MoveOn());
    }

    IEnumerator MoveOn(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneName);
    }
}
