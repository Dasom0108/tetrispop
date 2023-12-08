using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;

    Stage stage;
    Stage2 stage2;

    public bool isP1ready;
    public bool isP2ready;

    public int P1chara;
    public int P2chara;

    public bool Gameover;

    // Use this for initialization
    void Start()
    {
        Gameover = false;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(isP1ready && isP2ready)
        {
            Invoke("LoadScene", 3f);
            isP1ready = false;
            isP2ready = false;
        }

        if (Gameover)
        {
            Invoke("Pause", 2);
        }
    } 

    void LoadScene()
    {
        SceneManager.LoadScene(3);

    }

    void Pause()
    {
      Time.timeScale = 0;
 
    }

}
