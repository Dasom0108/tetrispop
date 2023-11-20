using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public static int w = 10;
    public static int h = 20;
    public static Transform[,] grid = new Transform[w, h];

    public static Vector2 roundVec2(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }

    // 테두리 안에 있는지 확인
    public static bool insideBorder(Vector2 pos)
    {
        // x좌표가 0~마지막 안에 있고 y가 0보다 같거나 커야 true
        return ((int)pos.x >= 0 && (int)pos.x < w && (int)pos.y >= 0);
    }

    // 한줄을 지우는 함수
    public static void deleteRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }

        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        // 줄지울때마다 스코어업
        GM.scoreUP();
    }

    // 한줄을 당기는(내리는) 함수
    public static void decreaseRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] != null)
            {
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;

                grid[x, y - 1].position += new Vector3(0, -1);
            }
        }
    }

    // y값부터 위의 모든 줄을 내리는 함수
    public static void decreaseRowAbove(int y)
    {
        for (int i = y; i < h; ++i)
            decreaseRow(i);
    }

    // 한줄이 다찼는지 확인하는 함수
    public static bool isRowFull(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] == null)
                return false;
        }
        return true;
    }

    // 전체를 돌면서 다 찬 줄을 삭제하고 내리는 함수
    public static void deleteFullRows()
    {
        bool combocheck = false;
        for (int y = 0; y < h; ++y)
        {
            // 한줄이 다찼으면
            if (isRowFull(y))
            {
                // 그줄을 삭제하고
                deleteRow(y);
                // 그다음줄부터 전부 한줄씩 당김
                decreaseRowAbove(y + 1);
                // --y하여 다음번에 다시 그 줄부터 검사
                --y;

                combocheck = true;
            }
        }

        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        // 한줄이라도 지우면 콤보업
        if (combocheck)
            GM.comboUP();
        // 아니면 콤보 초기화
        else
            GM.comboInit();
    }
}
