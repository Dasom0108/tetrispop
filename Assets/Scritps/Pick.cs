using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pick : MonoBehaviour
{
    public RectTransform rectTransform;
    private Vector3 MaxLimit;
    private Vector3 MinLimit;

    GameManager gameManager;

    public enum Chara { City, DDD, Kirby, Mario, Pikachu, Ditto, Isabell, Kuppa };
    public int P1chara;

    void Start()
    {
        gameManager =GameObject.Find("GameManager").GetComponent<GameManager>();
        rectTransform = this.GetComponent<RectTransform>();

        MaxLimit.x = -523f;
        MinLimit.x = 510f;
        MaxLimit.y = 0;
        MinLimit.y = -416;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveDir = rectTransform.localPosition;
        Vector3 oldDir = rectTransform.localPosition;

        if (Input.GetKeyDown("a"))
        {
            moveDir.x -= 342f;
            rectTransform.localPosition = moveDir;

        }
        else if (Input.GetKeyDown("d"))
        {
            moveDir.x += 342f;
            rectTransform.localPosition = moveDir;

        }

        if (Input.GetKeyDown("w"))
        {
            moveDir.y += 215;
            rectTransform.localPosition = moveDir;
        }
        else if (Input.GetKeyDown("s"))
        {
            moveDir.y -= 215;
            rectTransform.localPosition = moveDir;
        }

        if(moveDir.x <= MaxLimit.x || moveDir.x >= MinLimit.x || moveDir.y <= MinLimit.y || moveDir.y >= MaxLimit.y)
        {
            rectTransform.localPosition = oldDir;
            Debug.Log("out");

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "citizenOff" && Input.GetKey(KeyCode.Space))
        {
           P1chara = (int)Chara.City;
           Debug.Log(P1chara);
            gameManager.P1chara = P1chara;
            gameManager.isP1ready = true;

        }
    }

}
