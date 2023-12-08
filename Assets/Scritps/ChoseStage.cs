using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoseStage : MonoBehaviour
{
    [Header("On")]
    public Sprite CitizenOn;
    public Sprite KirbyOn;
    public Sprite MarioOn;
    public Sprite PikachuOn;

    [Header("Pick")]
    public Sprite Citizen1;
    public Sprite Kirby1;
    public Sprite Mario1;
    public Sprite Pikachu1;

    [Header("Pick2")]
    public Sprite DDD2;
    public Sprite Ditto2;
    public Sprite Isabell2;
    public Sprite Kuppa2;

    public RectTransform rectTransform;
    private Vector3 MaxLimit;
    private Vector3 MinLimit;

    private bool isChoose;
    public enum Chara { City, Kirby, Mario, Pikachu };
    public int P1chara;

    public Image OnePick;
    public Image TwoPick;

    public GameObject ClickSfx;
    public GameObject ChoseSfx;

    void Start()
    {
        isChoose = false;
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
            ClickSfx.SetActive(true);
            Invoke("OffClickSound", 0.3f);

        }
        else if (Input.GetKeyDown("d"))
        {
            moveDir.x += 342f;
            rectTransform.localPosition = moveDir;
            ClickSfx.SetActive(true);
            Invoke("OffClickSound", 0.3f);

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

            collision.gameObject.GetComponent<Image>().sprite = CitizenOn;
            OnePick.sprite = Citizen1;
            TwoPick.sprite = Isabell2;
            isChoose = true;
            Bounce();
            Invoke(LoadStage("AnimalCrossing"), 2);

        }

        else if (collision.name == "KirbyOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Kirby; //
            Debug.Log(P1chara);

            collision.gameObject.GetComponent<Image>().sprite = KirbyOn; // 
            OnePick.sprite = Kirby1; //
            OnePick.sprite = DDD2;
            isChoose = true;
            Bounce();

        }

        else if (collision.name == "MarioOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Mario; //

            collision.gameObject.GetComponent<Image>().sprite = MarioOn; // 
            OnePick.sprite = Mario1; //
            TwoPick.sprite = Kuppa2;
            isChoose = true;
            Bounce();

        }

        else if (collision.name == "PikachuOff" && Input.GetKey(KeyCode.Space))
        {
            P1chara = (int)Chara.Pikachu; //
            Debug.Log(P1chara);

            collision.gameObject.GetComponent<Image>().sprite = PikachuOn; // 
            OnePick.sprite = Pikachu1; //
            TwoPick.sprite = Ditto2;
            isChoose = true;
            Bounce();

        }
    }
    string LoadStage(string name)
    {
        SceneManager.LoadScene(name);
        return null;
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

    public void OffClickSound()
    {
        ClickSfx.SetActive(false);
    }
}
