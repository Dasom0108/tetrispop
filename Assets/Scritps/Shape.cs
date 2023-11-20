using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // 연속 움직임 제한시간
    private float moveTime = 0;
    // 마지막으로 떨어진 시간(1초마다 떨어지게)
    private float lastFall = 0;

    // 회전 중점 받음 
    public GameObject pivot = null;

    // Use this for initialization
    void Start()
    {
        lastFall = Time.time;

        if (!isValidGridPos())
        {
            // 게임오버 변수 true
            var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
            GM.gameover = true;

            // 고스트 삭제
            var BS = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
            Destroy(BS.currentGhost);

            // 부모만 남은 블럭 삭제
            DeleteParent();

            // 디버그남기고 현재 블럭 삭제
            Debug.Log("Game OVER");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 게임이 안 끝났을때만
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gameover == false)
        {
            // 위방향키를 누르면 pivot 기준으로 90도 회전
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.RotateAround(pivot.transform.position, Vector3.forward, 90.0f);

                if (isValidGridPos())
                    updateGrid();
                else
                    transform.RotateAround(pivot.transform.position, Vector3.forward, -90.0f);
            }

            var BS = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();

            // 왼 오 아래 방향키 이동
     
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
                // 아래 또는 마지막으로 떨어진지 1초가 지나면
                if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - lastFall >= 1)
                {
                    transform.position += new Vector3(0, -1);

                    if (isValidGridPos())
                        updateGrid();
                    else
                    {
                        transform.position += new Vector3(0, 1);
                        updateGrid();

                        // 처음부터 끝까지 돌면서 비어있는칸을 전부 지우고 한줄씩 내려줌
                        Grid.deleteFullRows();

                        // 고스트 및 다음블럭 삭제하고  새로운 블럭을 생성
                        Destroy(BS.currentGhost);
                        Destroy(BS.nextBlock);
                        BS.MakeBlock();

                        // 자식이 다 사라진 오브젝트들을 삭제
                        DeleteParent();

                        // 활성화를 멈춤
                        enabled = false;
                    }
                    lastFall = Time.time;
            }

            // 스페이스바를 누르면 바로 떨어짐
            if (Input.GetKeyDown(KeyCode.Space))
            {

                // 블럭의 위치를 고스트의 위치로 옮김
                transform.position = BS.currentGhost.transform.position;

                // Grid를 업데이트
                updateGrid();

                // 처음부터 끝까지 돌면서 비어있는칸을 전부 지우고 한줄씩 내려줌
                Grid.deleteFullRows();

                // 고스트 및 다음블럭 삭제하고  새로운 블럭을 생성
                Destroy(BS.currentGhost);
                Destroy(BS.nextBlock);
                BS.MakeBlock();

                // 자식이 다 사라진 오브젝트들을 삭제
                DeleteParent();

                // 활성화를 멈춤
                enabled = false;
            }
        }
    }


    // 이동이 정상적인지를 확인
    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            // 소수점을 반올림하여 딱맞게해줌
            Vector2 v = Grid.roundVec2(child.position);
            Debug.Log(v);
            // Pivot을 제외한 나머지만 검사
            if (child.tag != "Pivot")
            {
                // 화면밖으로 나가면 false
                if (!Grid.insideBorder(v))
                    return false;

                // grid에 들어있는애가 널이 아니고 내거가 아니면 false
                if (Grid.grid[(int)v.x, (int)v.y] != null
                    && Grid.grid[(int)v.x, (int)v.y].parent != transform)
                    return false;
            }
        }
        return true;
    }

    // 이동마다 새로운 좌표로 저장함
    void updateGrid()
    {
        for (int y = 0; y < Grid.h; ++y)
        {
            for (int x = 0; x < Grid.w; ++x)
            {
                if (Grid.grid[x, y] != null)
                {
                    // grid에 저장된애의 부모가 나면 즉 지금 이동하는 객체만 전부 null로 만듬
                    if (Grid.grid[x, y].parent == transform)
                        Grid.grid[x, y] = null;
                }
            }
        }

        // 이후 현재 위치에 다시 입력
        foreach (Transform child in transform)
        {
            if (child.tag != "Pivot")
            {
                Vector2 v = Grid.roundVec2(child.position);
                Grid.grid[(int)v.x, (int)v.y] = child;
            }
        }
    }

    // Pivot만 남은 부모오브젝트를 삭제
    public static void DeleteParent()
    {
        // 블럭들을 찾아줌
        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("Line");

        // 블럭의 자식이 다 없어지면 부모도 삭제
        foreach (GameObject child in Blocks)
        {
            int count = 0;
            foreach (Transform t in child.transform)
            {
                count++;
            }
            // Pivot만 남으면
            if (count == 1)
                Destroy(child);
        }
    }
}
