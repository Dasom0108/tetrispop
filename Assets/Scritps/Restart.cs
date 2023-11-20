using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public void restart()
    {
        // ���ӽ�ŸƮ ���� true
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        GM.gameover = false;
        GM.gamestart = true;

        // ���� �� �޺� �ʱ�ȭ
        GM.scoreInit();
        GM.comboInit();

        // Grid �ʱ�ȭ, �� ������Ʈ ���λ���
        for (int y = 0; y < Grid.h; ++y)
        {
            for (int x = 0; x < Grid.w; ++x)
            {
                Grid.grid[x, y] = null;
            }
        }

        // �ʵ忡 �� ���λ���
        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("Line");
        // ���� �ڽ����� ����
        foreach (GameObject child in Blocks)
        {
            Destroy(child);
        }

        // Restart ��ư ���� 
        Destroy(gameObject);
    }
}
