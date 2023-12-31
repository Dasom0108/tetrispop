using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ChangeSkin1 : MonoBehaviour
{          
    SpriteRenderer Frame;
    SpriteRenderer BG;
    SpriteRenderer Profile;

    private int nowP2Character;
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
        Frame = GameObject.Find("P2Frame").GetComponent<SpriteRenderer>();
        BG = GameObject.Find("P2BG").GetComponent<SpriteRenderer>();
        Profile = GameObject.Find("P2Profile").GetComponent<SpriteRenderer>();

         
        nowP2Character = gameManager.P2chara;

        Change(nowP2Character);
    }

    private void Change(int character)
    {
        switch (character)
        {
            case (0):
               Frame.sprite = AnimalFrame;
               BG.sprite = AnimalBG;
               Profile.sprite = citizenprofile;
               Citizen.SetActive(true);
                break;
            case (1):
               Frame.sprite = KirbyFrame;
               BG.sprite = KirbyBG;
               Profile.sprite = DDDprofile;
                DDD.SetActive(true);
                break;
            case (2):
                Frame.sprite = KirbyFrame;
                BG.sprite = KirbyBG;
                Profile.sprite = Kribyprofile;
                kirby.SetActive(true);
                break;
            case (3):
               Frame.sprite = MarioFrame;
               BG.sprite = MarioBG;
               Profile.sprite = Marioprofile;
                Mario.SetActive(true);
                break;
            case (4):
                Frame.sprite = PoketmonFrame;
                BG.sprite = PoketmonBG;
                Profile.sprite = Pikachuprofile;
                break;
            case (5):
               Frame.sprite = PoketmonFrame;
               BG.sprite = PoketmonBG;
               Profile.sprite = Dittoprofile;
                break;
            case (6):
               Frame.sprite = AnimalFrame;
               BG.sprite = AnimalBG;
               Profile.sprite = isabellprofile;
                break;
            case (7):
               Frame.sprite = MarioFrame;
               BG.sprite = MarioBG;
               Profile.sprite = Kuppaprofile;
                break;
        }
    }

}
