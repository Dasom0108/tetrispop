using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Kirby")]
    public GameObject[] Blocks = new GameObject[7];
    public GameObject[] GhostBlocks = new GameObject[7];
    public GameObject[] NextBlocks = new GameObject[7];

    //[Header("Mario")]

    public GameObject currentBlock = null;
    public GameObject currentGhost = null;
    public GameObject nextBlock = null;

    private int nextBlocknum = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gamestart == true)
        {
            MakeBlock();
            GM.gamestart = false;
        }
    }

    // ���� �����ϴ� �Լ�
    public void MakeBlock()
    {
        // ������ �ȳ��������� ����
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gameover == false)
        {
            // �������� ������(�� ó�� ������ �������� �Ѵ� ����)
            if (nextBlock == null)
            {
                var blocknum = Random.Range(0, Blocks.Length);
                currentBlock = Instantiate(Blocks[blocknum], transform.position, Quaternion.identity);
                //currentGhost = Instantiate(GhostBlocks[blocknum], transform.position, Quaternion.identity);
            }
            // �������� �ִٸ� �������� ��ȣ�� ������ ����
            else
            {
                currentBlock = Instantiate(Blocks[nextBlocknum], transform.position, Quaternion.identity);
               // currentGhost = Instantiate(GhostBlocks[nextBlocknum], transform.position, Quaternion.identity);
            }

            // ���� ���� ����
            MakeNextBlock();
        }
    }

    // ���� �����ڸ� ���ϰ� ����
    public void MakeNextBlock()
    {
       // nextBlocknum = Random.Range(0, NextBlocks.Length);
        Vector3 nextBlockPos = new Vector3(0.1f, 17.6f);
        if (nextBlocknum == 0)
            nextBlockPos += new Vector3(0.2f, 0.2f);
        else if (nextBlocknum == 1)
            nextBlockPos += new Vector3(0.2f, 0.0f);

       // nextBlock = Instantiate(NextBlocks[nextBlocknum], nextBlockPos, Quaternion.identity);
    }
}
