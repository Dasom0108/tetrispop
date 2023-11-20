using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    Stage stage;
    private float nextFallTime;
    private float fallCycle = 0.1f;

    [Header("Trash")]
    public GameObject TrashPrefab;
    public Transform trashNode1;


    void Start()
    {
        stage = GameObject.Find("1p Stage").GetComponent<Stage>();
        nextFallTime = Time.time + fallCycle;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;

        if (Time.time > nextFallTime)
        {
            Debug.Log("fall");
            nextFallTime = Time.time + fallCycle;   // ���� ������ �ð� �缳��
            moveDir.y = -1; //  �Ʒ��� �� ĭ �̵�
        }

        //���ذ� 10�̸� �������� ������
        if (stage.GetDmg >= 10)
        {
            Attack();
            stage.GetDmg = 0;
            while (MoveTrash(Vector3.down))
            {
            }
            trashNode1.transform.position = moveDir;

        }

 
    }

    // �������� ���� ȣ��
    void Attack()
    {
        int index;
        index = Random.Range(0, 11); // �������� 0~6 ������ �� ����

        switch (index)
        {
            // ���� ����

            case 0: // 1
                //CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 1: // 2
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 2: // 3
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 3: // 4
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
               // CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 4: //  5
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 5: //  6
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 6: // 7
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 7: // 8
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 8: // 9
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;

            case 9: // 10
                CreateTrash(trashNode1, new Vector2(-5f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-4f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-3f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(-1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(0f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(1f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(2f, 10f), Color.gray, stage.Basic);
                CreateTrash(trashNode1, new Vector2(3f, 10f), Color.gray, stage.Basic);
                //CreateTrash(trashNode1, new Vector2(4f, 10f), Color.gray, stage.Basic);
                break;
        }

    }

    //�������� ����
    Tile CreateTrash(Transform parent, Vector2 position, Color color, Sprite img, int order = 1)
    {
        var go = Instantiate(TrashPrefab); // tilePrefab�� ������ ������Ʈ ����
        go.transform.parent = parent; // �θ� ����
        go.transform.localPosition = position; // ��ġ ����

        var tile = go.GetComponent<Tile>(); // tilePrefab�� Tile��ũ��Ʈ �ҷ�����
        tile.color = color; // ���� ����
        tile.sprite = img; // ��������Ʈ
        tile.sortingOrder = order; // ���� ����

        return tile;
    }

    bool MoveTrash(Vector3 moveDir)
    {
        //�̵� �Ұ��� ���ư��� ���� �� ����
        Vector3 oldPos1 = trashNode1.transform.position;

        //�̵��ϱ�
        trashNode1.transform.position += moveDir;
 

        // �̵� �Ұ��� ���� ��ġ, ȸ�� ���� ���ư���
        if (!CanMoveTo(trashNode1))
        {

            trashNode1.transform.position = oldPos1;

            //�ٴڿ� ��Ҵٴ� �ǹ� = �̵� �Ұ��ϰ� ���� �Ʒ��� �������� �ִ� ��Ȳ
            if ((int)moveDir.y == -1 && (int)moveDir.x == 0)
            {
                Debug.Log("�ٴ�");

                AddToBoard(trashNode1);

                CheckBoardColumn();


            }
            return false;
        }
        return true;
    }

    // �̵� �������� üũ �� True or False ��ȯ�ϴ� �޼���
    bool CanMoveTo(Transform root)  //tetrominoNode�� �Ű����� root�� ��������
    {
        //tetrominoNode�� �ڽ� Ÿ���� ��� �˻�
        for (int i = 0; i < root.childCount; ++i)
        {
            var node = root.GetChild(i);

            //����Ƽ ��ǥ�迡�� ��Ʈ���� ��ǥ��� ��ȯ
            int x = Mathf.RoundToInt(node.transform.position.x + stage.halfWidth);
            int y = Mathf.RoundToInt(node.transform.position.y + stage.halfHeight - 1);

            //�̵� ������ ��ǥ���� Ȯ�� �� ��ȯ
            if (x < 0 || x > stage.boardWidth - 1)
                return false;
            if (y < 0)
                return false;

            // �̹� �ٸ� Ÿ���� �ִ��� Ȯ��
            var column = stage.boardNode.Find(y.ToString());

            if (column != null && column.Find(x.ToString()) != null)
                return false;
            
        }
        return true;
    }

    void AddToBoard(Transform root)
    {
        while (root.childCount > 0)
        {
            var node = root.GetChild(0);

            //����Ƽ ��ǥ�迡�� ��Ʈ���� ��ǥ��� ��ȯ
            int x = Mathf.RoundToInt(node.transform.position.x + stage.halfWidth);
            int y = Mathf.RoundToInt(node.transform.position.y + stage.halfHeight - 1);

            //�θ��� : �� ���(y ��ġ), ������Ʈ �̸� : x ��ġ
            node.parent = stage.boardNode.Find(y.ToString());
            node.name = x.ToString();
        }
    }

    void CheckBoardColumn()
    {
        bool isCleared = false;

        // �ϼ��� �� == ���� �ڽ� ������ ���� ũ��
        foreach (Transform column in stage.boardNode)
        {
            if (column.childCount >= stage.boardWidth)
            {
                column.DetachChildren();
                isCleared = true;
            }
        }

        // ��� �ִ� ���� �����ϸ� �Ʒ��� ������
        if (isCleared)
        {
            //���� �ٴ� ���� ���� �ʿ䰡 �����Ƿ� index 1 ���� for�� ����
            for (int i = 1; i < stage.boardNode.childCount; ++i)
            {
                var column = stage.boardNode.Find(i.ToString());

                // �̹� ��� �ִ� ���� ����
                if (column.childCount == 0)
                    continue;

                // ���� �� �Ʒ��ʿ� �� ���� �����ϴ��� Ȯ��, �� �ุŭ emptyCol ����
                int emptyCol = 0;
                int j = i - 1;
                while (j >= 0)
                {
                    if (stage.boardNode.Find(j.ToString()).childCount == 0)
                    {
                        emptyCol++;
                    }
                    j--;
                }

                // ���� �� �Ʒ��ʿ� �� �� ����� �Ʒ��� ����
                if (emptyCol > 0)
                {
                    var targetColumn = stage.boardNode.Find((i - emptyCol).ToString());

                    while (column.childCount > 0)
                    {
                        column.DetachChildren();
                        Transform tile = column.GetChild(0);
                        tile.parent = targetColumn;
                        tile.transform.position += new Vector3(0, -emptyCol, 0);
                    }
                }
            }
        }
    }
}






 
