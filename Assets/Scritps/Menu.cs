using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    SlideEffect slideEffect;
    void Start()
    {
        slideEffect = GameObject.Find("Menu").GetComponent<SlideEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            slideEffect.enabled = true;
        }
    }

    public void localvs()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}
