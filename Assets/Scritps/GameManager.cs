using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int combo = 0;

    public bool gamestart = false;
    public bool gameover = false;
    public bool restart = false;

    public GameObject ReStart = null;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == true)
        {
            if (restart == false)
            {
                // 리스타트 버튼 생성
                Instantiate(ReStart, new Vector3(4.5f, 10.0f), Quaternion.identity);
                restart = true;
            }
        }
        else
            restart = false;
    }

    // 스코어 업
    public void scoreUP()
    {
        score += 1000;
        scoreUpdate();
    }

    // 스코어텍스트 업데이트
    private void scoreUpdate()
    {
        var scoretext = GameObject.FindGameObjectWithTag("Score");
        //scoretext.GetComponent<Text>().text = Convert.ToString(score);
    }

    // 스코어 0으로 초기화
    public void scoreInit()
    {
        score = 0;
        scoreUpdate();
    }

    // 콤보 업 + 콤보에 따른 스코어업
    public void comboUP()
    {
        if (combo >= 1)
        {
            score += combo * 500;
            scoreUpdate();
        }

        combo++;
        comboUpdate();
    }

    // 콤보 0으로 초기화
    public void comboInit()
    {
        combo = 0;
        comboUpdate();
    }

    // 콤보텍스트 업데이트
    private void comboUpdate()
    {
        //var combotext = GameObject.FindGameObjectWithTag("Combo");
       // combotext.GetComponent<Text>().text = Convert.ToString(combo);
    }
}
