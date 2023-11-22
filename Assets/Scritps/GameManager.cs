using System.Collections;
using System.Collections.Generic;
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

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(isP1ready && isP2ready)
        {
            SceneManager.LoadScene(0);
            isP1ready = false;
            isP2ready = false;
        }
    } 

}
