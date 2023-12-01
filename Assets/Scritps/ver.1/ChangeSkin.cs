using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    //1P
    SpriteRenderer P1Frame;
    SpriteRenderer P1BG;
    SpriteRenderer P1Profile;

    private int nowP1Character;

    [Header("Animal")]
    public Sprite AnimalBG;
    public Sprite AnimalFrame;
    public Sprite citizenprofile;
    public Sprite isabellprofile;

    [Header("Kirby")]
    public Sprite KirbyBG;
    public Sprite KirbyFrame;
    public Sprite Kribyprofile;
    public Sprite DDDprofile;

    [Header("Mario")]
    public Sprite MarioBG;
    public Sprite MarioFrame;
    public Sprite Marioprofile;
    public Sprite Kuppaprofile;

    [Header("Poketmon")]
    public Sprite PoketmonBG;
    public Sprite PoketmonFrame;
    public Sprite Pikachuprofile;
    public Sprite Dittoprofile;

    [Header("Character")]
    public SpriteRenderer Kirby;
    public SpriteRenderer DDD;

    GameManager gameManager;

    private void Start()
    {
        DDD.enabled = false;
        Kirby.enabled = false;

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        P1Frame = GameObject.Find("P1Frame").GetComponent<SpriteRenderer>();
        P1BG = GameObject.Find("P1BG").GetComponent<SpriteRenderer>();
        P1Profile = GameObject.Find("P1Profile").GetComponent<SpriteRenderer>();

        DDD = GameObject.Find("P1DDD").GetComponent<SpriteRenderer>();
        Kirby = GameObject.Find("P1Kriby").GetComponent<SpriteRenderer>();

        nowP1Character = gameManager.P1chara;

        ChangeP1(nowP1Character);
    }

    private void ChangeP1(int character)
    {
        switch(character)
        {
            case (0):
                P1Frame.sprite = AnimalFrame;
                P1BG.sprite = AnimalBG;
                P1Profile.sprite = citizenprofile;
                break;
            case (1):
                P1Frame.sprite = KirbyFrame;
                P1BG.sprite = KirbyBG;
                P1Profile.sprite = DDDprofile;
                DDD.enabled = true;
                break;
            case (2):
                P1Frame.sprite = KirbyFrame;
                P1BG.sprite = KirbyBG;
                P1Profile.sprite = Kribyprofile;
                Kirby.enabled = true;
                break;
            case (3):
                P1Frame.sprite = MarioFrame;
                P1BG.sprite = MarioBG;
                P1Profile.sprite = Marioprofile;
                break;
            case (4):
                P1Frame.sprite = PoketmonFrame;
                P1BG.sprite = PoketmonBG;
                P1Profile.sprite = Pikachuprofile;
                break;
            case (5):
                P1Frame.sprite = PoketmonFrame;
                P1BG.sprite = PoketmonBG;
                P1Profile.sprite = Dittoprofile;
                break;
            case (6):
                P1Frame.sprite = AnimalFrame;
                P1BG.sprite = AnimalBG;
                P1Profile.sprite = isabellprofile;
                break;
            case (7):
                P1Frame.sprite = MarioFrame;
                P1BG.sprite = MarioBG;
                P1Profile.sprite = Kuppaprofile;
                break;
        }
    }

}
