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
            nextFallTime = Time.time + fallCycle;   // 다음 떨어질 시간 재설정
            moveDir.y = -1; //  아래로 한 칸 이동
        }

        //피해가 10이면 가비지줄 내려옴
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

    // 쓰레기줄 생성 호출
    void Attack()
    {
        int index;
        index = Random.Range(0, 11); // 랜덤으로 0~6 사이의 값 생성

        switch (index)
        {
            // 공격 패턴

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

    //쓰레기줄 생성
    Tile CreateTrash(Transform parent, Vector2 position, Color color, Sprite img, int order = 1)
    {
        var go = Instantiate(TrashPrefab); // tilePrefab를 복제한 오브젝트 생성
        go.transform.parent = parent; // 부모 지정
        go.transform.localPosition = position; // 위치 지정

        var tile = go.GetComponent<Tile>(); // tilePrefab의 Tile스크립트 불러오기
        tile.color = color; // 색상 지정
        tile.sprite = img; // 스프라이트
        tile.sortingOrder = order; // 순서 지정

        return tile;
    }

    bool MoveTrash(Vector3 moveDir)
    {
        //이동 불가시 돌아가기 위한 값 저장
        Vector3 oldPos1 = trashNode1.transform.position;

        //이동하기
        trashNode1.transform.position += moveDir;
 

        // 이동 불가시 이전 위치, 회전 으로 돌아가기
        if (!CanMoveTo(trashNode1))
        {

            trashNode1.transform.position = oldPos1;

            //바닥에 닿았다는 의미 = 이동 불가하고 현재 아래로 떨어지고 있는 상황
            if ((int)moveDir.y == -1 && (int)moveDir.x == 0)
            {
                Debug.Log("바닥");

                AddToBoard(trashNode1);

                CheckBoardColumn();


            }
            return false;
        }
        return true;
    }

    // 이동 가능한지 체크 후 True or False 반환하는 메서드
    bool CanMoveTo(Transform root)  //tetrominoNode를 매개변수 root로 가져오기
    {
        //tetrominoNode의 자식 타일을 모두 검사
        for (int i = 0; i < root.childCount; ++i)
        {
            var node = root.GetChild(i);

            //유니티 좌표계에서 테트리스 좌표계로 변환
            int x = Mathf.RoundToInt(node.transform.position.x + stage.halfWidth);
            int y = Mathf.RoundToInt(node.transform.position.y + stage.halfHeight - 1);

            //이동 가능한 좌표인지 확인 후 반환
            if (x < 0 || x > stage.boardWidth - 1)
                return false;
            if (y < 0)
                return false;

            // 이미 다른 타일이 있는지 확인
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

            //유니티 좌표계에서 테트리스 좌표계로 변환
            int x = Mathf.RoundToInt(node.transform.position.x + stage.halfWidth);
            int y = Mathf.RoundToInt(node.transform.position.y + stage.halfHeight - 1);

            //부모노드 : 행 노드(y 위치), 오브젝트 이름 : x 위치
            node.parent = stage.boardNode.Find(y.ToString());
            node.name = x.ToString();
        }
    }

    void CheckBoardColumn()
    {
        bool isCleared = false;

        // 완성된 행 == 행의 자식 갯수가 가로 크기
        foreach (Transform column in stage.boardNode)
        {
            if (column.childCount >= stage.boardWidth)
            {
                column.DetachChildren();
                isCleared = true;
            }
        }

        // 비어 있는 행이 존재하면 아래로 내리기
        if (isCleared)
        {
            //가장 바닥 행은 내릴 필요가 없으므로 index 1 부터 for문 시작
            for (int i = 1; i < stage.boardNode.childCount; ++i)
            {
                var column = stage.boardNode.Find(i.ToString());

                // 이미 비어 있는 행은 무시
                if (column.childCount == 0)
                    continue;

                // 현재 행 아래쪽에 빈 행이 존재하는지 확인, 빈 행만큼 emptyCol 증가
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

                // 현재 행 아래쪽에 빈 행 존재시 아래로 내림
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






 
