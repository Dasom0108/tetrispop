using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // ���� ������ ���ѽð�
    private float moveTime = 0;
    // ���������� ������ �ð�(1�ʸ��� ��������)
    private float lastFall = 0;

    // ȸ�� ���� ���� 
    public GameObject pivot = null;

    // Use this for initialization
    void Start()
    {
        lastFall = Time.time;

        if (!isValidGridPos())
        {
            // ���ӿ��� ���� true
            var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
            GM.gameover = true;

            // ��Ʈ ����
            var BS = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
            Destroy(BS.currentGhost);

            // �θ� ���� �� ����
            DeleteParent();

            // ����׳���� ���� �� ����
            Debug.Log("Game OVER");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ������ �� ����������
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gameover == false)
        {
            // ������Ű�� ������ pivot �������� 90�� ȸ��
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.RotateAround(pivot.transform.position, Vector3.forward, 90.0f);

                if (isValidGridPos())
                    updateGrid();
                else
                    transform.RotateAround(pivot.transform.position, Vector3.forward, -90.0f);
            }

            var BS = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();

            // �� �� �Ʒ� ����Ű �̵�
     
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position += new Vector3(-1, 0);

                    if (isValidGridPos())
                        updateGrid();
                    else
                        transform.position += new Vector3(1, 0);
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position += new Vector3(1, 0);

                    if (isValidGridPos())
                        updateGrid();
                    else
                        transform.position += new Vector3(-1, 0);
                }
                // �Ʒ� �Ǵ� ���������� �������� 1�ʰ� ������
                if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - lastFall >= 1)
                {
                    transform.position += new Vector3(0, -1);

                    if (isValidGridPos())
                        updateGrid();
                    else
                    {
                        transform.position += new Vector3(0, 1);
                        updateGrid();

                        // ó������ ������ ���鼭 ����ִ�ĭ�� ���� ����� ���پ� ������
                        Grid.deleteFullRows();

                        // ��Ʈ �� ������ �����ϰ�  ���ο� ���� ����
                        Destroy(BS.currentGhost);
                        Destroy(BS.nextBlock);
                        BS.MakeBlock();

                        // �ڽ��� �� ����� ������Ʈ���� ����
                        DeleteParent();

                        // Ȱ��ȭ�� ����
                        enabled = false;
                    }
                    lastFall = Time.time;
            }

            // �����̽��ٸ� ������ �ٷ� ������
            if (Input.GetKeyDown(KeyCode.Space))
            {

                // ���� ��ġ�� ��Ʈ�� ��ġ�� �ű�
                transform.position = BS.currentGhost.transform.position;

                // Grid�� ������Ʈ
                updateGrid();

                // ó������ ������ ���鼭 ����ִ�ĭ�� ���� ����� ���پ� ������
                Grid.deleteFullRows();

                // ��Ʈ �� ������ �����ϰ�  ���ο� ���� ����
                Destroy(BS.currentGhost);
                Destroy(BS.nextBlock);
                BS.MakeBlock();

                // �ڽ��� �� ����� ������Ʈ���� ����
                DeleteParent();

                // Ȱ��ȭ�� ����
                enabled = false;
            }
        }
    }


    // �̵��� ������������ Ȯ��
    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            // �Ҽ����� �ݿø��Ͽ� ���°�����
            Vector2 v = Grid.roundVec2(child.position);
            Debug.Log(v);
            // Pivot�� ������ �������� �˻�
            if (child.tag != "Pivot")
            {
                // ȭ������� ������ false
                if (!Grid.insideBorder(v))
                    return false;

                // grid�� ����ִ¾ְ� ���� �ƴϰ� ���Ű� �ƴϸ� false
                if (Grid.grid[(int)v.x, (int)v.y] != null
                    && Grid.grid[(int)v.x, (int)v.y].parent != transform)
                    return false;
            }
        }
        return true;
    }

    // �̵����� ���ο� ��ǥ�� ������
    void updateGrid()
    {
        for (int y = 0; y < Grid.h; ++y)
        {
            for (int x = 0; x < Grid.w; ++x)
            {
                if (Grid.grid[x, y] != null)
                {
                    // grid�� ����Ⱦ��� �θ� ���� �� ���� �̵��ϴ� ��ü�� ���� null�� ����
                    if (Grid.grid[x, y].parent == transform)
                        Grid.grid[x, y] = null;
                }
            }
        }

        // ���� ���� ��ġ�� �ٽ� �Է�
        foreach (Transform child in transform)
        {
            if (child.tag != "Pivot")
            {
                Vector2 v = Grid.roundVec2(child.position);
                Grid.grid[(int)v.x, (int)v.y] = child;
            }
        }
    }

    // Pivot�� ���� �θ������Ʈ�� ����
    public static void DeleteParent()
    {
        // ������ ã����
        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("Line");

        // ���� �ڽ��� �� �������� �θ� ����
        foreach (GameObject child in Blocks)
        {
            int count = 0;
            foreach (Transform t in child.transform)
            {
                count++;
            }
            // Pivot�� ������
            if (count == 1)
                Destroy(child);
        }
    }
}
