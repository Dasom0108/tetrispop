using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoseStage : MonoBehaviour
{
    [Header("On")]
    public Sprite CitizenOn;
    public Sprite KirbyOn;
    public Sprite MarioOn;
    public Sprite PikachuOn;

    [Header("Pick")]
    public Sprite Citizen;
    public Sprite DDD;
    public Sprite Kirby;
    public Sprite Mario;
    public Sprite Pikachu;
    public Sprite Ditto;
    public Sprite Isabell;
    public Sprite Kuppa;

    public RectTransform rectTransform;
    private Vector3 MaxLimit;
    private Vector3 MinLimit;

    GameManager gameManager;
    private bool isChoose;
    public enum Chara { City, Kirby, Mario, Pikachu };
    public int P1chara;

    public Image OnePick;
    public Image TwoPick;

    void Start()
    {
        isChoose = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rectTransform = this.GetComponent<RectTransform>();
        OnePick = GameObject.Find("1Pptick").GetComponent<Image>();
        TwoPick = GameObject.Find("2Pptick").GetComponent<Image>();

        MaxLimit.x = -523f;
        MinLimit.x = 510f;
        MaxLimit.y = 0;
        MinLimit.y = -416;
    }

    private void Update()
    {
        if (!isChoose)
        {
            Move();
        }

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

        if (moveDir.x <= MaxLimit.x || moveDir.x >= MinLimit.x || moveDir.y <= MinLimit.y || moveDir.y >= MaxLimit.y)
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
            collision.gameObject.GetComponent<Image>().sprite = CitizenOn;
            OnePick.sprite = Citizen;
            isChoose = true;
            Bounce();

        }

        else if (collision.name == "KirbyOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Kirby; //
            Debug.Log(P1chara);
            gameManager.P1chara = P1chara;
            gameManager.isP1ready = true;
            collision.gameObject.GetComponent<Image>().sprite = KirbyOn; // 
            OnePick.sprite = Kirby; //
            isChoose = true;
            Bounce();

        }

        else if (collision.name == "MarioOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Mario; //
            Debug.Log(P1chara);
            gameManager.P1chara = P1chara;
            gameManager.isP1ready = true;
            collision.gameObject.GetComponent<Image>().sprite = MarioOn; // 
            OnePick.sprite = Mario; //
            isChoose = true;
            Bounce();

        }

        else if (collision.name == "PikachuOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Pikachu; //
            Debug.Log(P1chara);
            gameManager.P1chara = P1chara;
            gameManager.isP1ready = true;
            collision.gameObject.GetComponent<Image>().sprite = PikachuOn; // 
            OnePick.sprite = Pikachu; //
            isChoose = true;
            Bounce();

        }
    }
    private void Bounce()
    {
        float time = 0;
        float _size = 5;
        float _upSizeTime = 0.2f;

        if (time <= _upSizeTime)
        {
            transform.localScale = Vector3.one * (1 + _size * time);
        }
        else if (time <= _upSizeTime * 2)
        {
            transform.localScale = Vector3.one * (2 * _size * _upSizeTime + 1 - time * _size);
        }
        else
        {
            transform.localScale = Vector3.one;
        }
        time += Time.deltaTime;
    }
}
