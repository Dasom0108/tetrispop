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
                // ����ŸƮ ��ư ����
                Instantiate(ReStart, new Vector3(4.5f, 10.0f), Quaternion.identity);
                restart = true;
            }
        }
        else
            restart = false;
    }

    // ���ھ� ��
    public void scoreUP()
    {
        score += 1000;
        scoreUpdate();
    }

    // ���ھ��ؽ�Ʈ ������Ʈ
    private void scoreUpdate()
    {
        var scoretext = GameObject.FindGameObjectWithTag("Score");
        //scoretext.GetComponent<Text>().text = Convert.ToString(score);
    }

    // ���ھ� 0���� �ʱ�ȭ
    public void scoreInit()
    {
        score = 0;
        scoreUpdate();
    }

    // �޺� �� + �޺��� ���� ���ھ��
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

    // �޺� 0���� �ʱ�ȭ
    public void comboInit()
    {
        combo = 0;
        comboUpdate();
    }

    // �޺��ؽ�Ʈ ������Ʈ
    private void comboUpdate()
    {
        //var combotext = GameObject.FindGameObjectWithTag("Combo");
       // combotext.GetComponent<Text>().text = Convert.ToString(combo);
    }
}
