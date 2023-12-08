using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    SlideEffect slideEffect;
    public GameObject Op;
    public GameObject Howto;
    public GameObject ClickSfx;
    void Start()
    {
        slideEffect = GameObject.Find("Menu").GetComponent<SlideEffect>();
        slideEffect.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            slideEffect.enabled = true;
        }

        if(Input.GetMouseButtonDown(0))
        {
            ClickSfx.SetActive(true);
            Invoke("OffClickSound", 0.5f);
        }
    }

    public void OffClickSound()
    {
        ClickSfx.SetActive(false);
    }

    public void Localvs()
    {
        SceneManager.LoadScene(1);
    }

    public void Pcvs()
    {
        SceneManager.LoadScene(2);
    }


    public void Exit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

    public void Option()
    {
        Instantiate(Op, gameObject.transform);
        Op.SetActive(true);

    }
    public void Howt()
    {
       Instantiate(Howto, gameObject.transform);
       Howto.SetActive(true);

    }
}
