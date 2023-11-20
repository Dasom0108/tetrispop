using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // 회전 중점 받음 
    public GameObject pivot = null;

    // Use this for initialization
    void Start()
    {
        //if (!isValidGridPos())
        //{
        //    Debug.Log("Game OVER");
        //    Destroy(gameObject);
        //}

        var SP = GameObject.FindGameObjectWithTag("Spawner");
        var cBlock = SP.GetComponent<Spawner>().currentBlock;

        // 고스트의 회전값은 블럭과 똑같게
        transform.rotation = cBlock.transform.rotation;
        // 고스트의 위치도 블럭과 똑같게
        transform.position = cBlock.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 게임이 안 끝났을때만
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gameover == false)
        {
            var SP = GameObject.FindGameObjectWithTag("Spawner");
            var cBlock = SP.GetComponent<Spawner>().currentBlock;

            // 고스트의 회전값은 블럭과 똑같게
            transform.rotation = cBlock.transform.rotation;
            // 고스트의 위치도 블럭과 똑같게
            transform.position = cBlock.transform.position;

            // 갈수있는 곳이면 고스트의 포지션의 y값을 -1하여 못가는곳까지 내림
            while (isValidGridPos())
            {
                transform.position += new Vector3(0, -1.0f);
            }
            // 기준치보다 1칸 더내려가므로 1칸 다시올림
            transform.position += new Vector3(0, 1.0f);
        }
    }

    // 이동이 정상적인지를 확인
    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            // 소수점을 반올림하여 딱맞게해줌
            Vector2 v = Grid.roundVec2(child.position);

            // Pivot을 제외한 나머지만 검사
            if (child.tag != "Pivot")
            {
                // 화면밖으로 나가면 false
                if (!Grid.insideBorder(v))
                    return false;

                var SP = GameObject.FindGameObjectWithTag("Spawner");
                var cBlock = SP.GetComponent<Spawner>().currentBlock;

                // grid에 들어있는애가 널이 아니면 false
               // if (Grid.grid[(int)v.x, (int)v.y] != null
                   // && Grid.grid[(int)v.x, (int)v.y].parent != cBlock.transform)
                    //return false;
            }
        }
        return true;
    }
}
