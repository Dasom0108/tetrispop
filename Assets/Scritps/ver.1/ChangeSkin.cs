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

    // game sound,BG
    [Header("BG")]
    public GameObject MarioGmaeBG;
    public GameObject KirbyGameBG;
    public GameObject PoketmonGameBG;
    public GameObject AnimalCrossingGameBG;
    [Header("BGM")]
    public GameObject KirbySound;
    public GameObject MarioSound;
    public GameObject AnimalSound;

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
    public GameObject Citizen;
    public GameObject DDD;
    public GameObject kirby;
    public GameObject Mario;

    GameManager gameManager;

    private void Start()
    {
        Citizen.SetActive(false);
        DDD.SetActive(false);
        kirby.SetActive(false);
        Mario.SetActive(false);


        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        P1Frame = GameObject.Find("P1Frame").GetComponent<SpriteRenderer>();
        P1BG = GameObject.Find("P1BG").GetComponent<SpriteRenderer>();
        P1Profile = GameObject.Find("P1Profile").GetComponent<SpriteRenderer>();

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

                AnimalCrossingGameBG.SetActive(true);
                AnimalSound.SetActive(true);

                Citizen.SetActive(true);
                break;
            case (1):
                P1Frame.sprite = KirbyFrame;
                P1BG.sprite = KirbyBG;
                P1Profile.sprite = DDDprofile;

               KirbyGameBG.SetActive(true);
                KirbySound.SetActive(true);

                DDD.SetActive(true);
                break;
            case (2):
                P1Frame.sprite = KirbyFrame;
                P1BG.sprite = KirbyBG;
                P1Profile.sprite = Kribyprofile;
                KirbyGameBG.SetActive(true);
                KirbySound.SetActive(true);

                kirby.SetActive(true);
                break;
            case (3):
                P1Frame.sprite = MarioFrame;
                P1BG.sprite = MarioBG;
                P1Profile.sprite = Marioprofile;
                Mario.SetActive(true);
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

                AnimalCrossingGameBG.SetActive(true);
                AnimalSound.SetActive(true);

                break;
            case (7):
                P1Frame.sprite = MarioFrame;
                P1BG.sprite = MarioBG;
                P1Profile.sprite = Kuppaprofile;
                break;
        }
    }

}
