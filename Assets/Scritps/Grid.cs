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

    // �׵θ� �ȿ� �ִ��� Ȯ��
    public static bool insideBorder(Vector2 pos)
    {
        // x��ǥ�� 0~������ �ȿ� �ְ� y�� 0���� ���ų� Ŀ�� true
        return ((int)pos.x >= 0 && (int)pos.x < w && (int)pos.y >= 0);
    }

    // ������ ����� �Լ�
    public static void deleteRow(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }

        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        // �����ﶧ���� ���ھ��
        GM.scoreUP();
    }

    // ������ ����(������) �Լ�
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

    // y������ ���� ��� ���� ������ �Լ�
    public static void decreaseRowAbove(int y)
    {
        for (int i = y; i < h; ++i)
            decreaseRow(i);
    }

    // ������ ��á���� Ȯ���ϴ� �Լ�
    public static bool isRowFull(int y)
    {
        for (int x = 0; x < w; ++x)
        {
            if (grid[x, y] == null)
                return false;
        }
        return true;
    }

    // ��ü�� ���鼭 �� �� ���� �����ϰ� ������ �Լ�
    public static void deleteFullRows()
    {
        bool combocheck = false;
        for (int y = 0; y < h; ++y)
        {
            // ������ ��á����
            if (isRowFull(y))
            {
                // ������ �����ϰ�
                deleteRow(y);
                // �״����ٺ��� ���� ���پ� ���
                decreaseRowAbove(y + 1);
                // --y�Ͽ� �������� �ٽ� �� �ٺ��� �˻�
                --y;

                combocheck = true;
            }
        }

        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        // �����̶� ����� �޺���
        if (combocheck)
            GM.comboUP();
        // �ƴϸ� �޺� �ʱ�ȭ
        else
            GM.comboInit();
    }
}
