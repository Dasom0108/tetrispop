using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public void restart()
    {
        // 게임스타트 변수 true
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        GM.gameover = false;
        GM.gamestart = true;

        // 점수 및 콤보 초기화
        GM.scoreInit();
        GM.comboInit();

        // Grid 초기화, 및 오브젝트 전부삭제
        for (int y = 0; y < Grid.h; ++y)
        {
            for (int x = 0; x < Grid.w; ++x)
            {
                Grid.grid[x, y] = null;
            }
        }

        // 필드에 블럭 전부삭제
        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("Line");
        // 블럭의 자식전부 삭제
        foreach (GameObject child in Blocks)
        {
            Destroy(child);
        }

        // Restart 버튼 삭제 
        Destroy(gameObject);
    }
}
