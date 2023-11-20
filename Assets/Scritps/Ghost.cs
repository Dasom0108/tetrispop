using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // ȸ�� ���� ���� 
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

        // ��Ʈ�� ȸ������ ���� �Ȱ���
        transform.rotation = cBlock.transform.rotation;
        // ��Ʈ�� ��ġ�� ���� �Ȱ���
        transform.position = cBlock.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ������ �� ����������
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        if (GM.gameover == false)
        {
            var SP = GameObject.FindGameObjectWithTag("Spawner");
            var cBlock = SP.GetComponent<Spawner>().currentBlock;

            // ��Ʈ�� ȸ������ ���� �Ȱ���
            transform.rotation = cBlock.transform.rotation;
            // ��Ʈ�� ��ġ�� ���� �Ȱ���
            transform.position = cBlock.transform.position;

            // �����ִ� ���̸� ��Ʈ�� �������� y���� -1�Ͽ� �����°����� ����
            while (isValidGridPos())
            {
                transform.position += new Vector3(0, -1.0f);
            }
            // ����ġ���� 1ĭ ���������Ƿ� 1ĭ �ٽÿø�
            transform.position += new Vector3(0, 1.0f);
        }
    }

    // �̵��� ������������ Ȯ��
    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            // �Ҽ����� �ݿø��Ͽ� ���°�����
            Vector2 v = Grid.roundVec2(child.position);

            // Pivot�� ������ �������� �˻�
            if (child.tag != "Pivot")
            {
                // ȭ������� ������ false
                if (!Grid.insideBorder(v))
                    return false;

                var SP = GameObject.FindGameObjectWithTag("Spawner");
                var cBlock = SP.GetComponent<Spawner>().currentBlock;

                // grid�� ����ִ¾ְ� ���� �ƴϸ� false
               // if (Grid.grid[(int)v.x, (int)v.y] != null
                   // && Grid.grid[(int)v.x, (int)v.y].parent != cBlock.transform)
                    //return false;
            }
        }
        return true;
    }
}
