using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class SoloStage : Stage
{
    public TextMeshProUGUI TextTime;
    private float LimitT;
    private float NowT;

    void Update()
    {
        NowT += Time.deltaTime;
        TextTime.text = NowT + "√ ";

        if(SceneManager.GetActiveScene().name == "AnimalCrossing")
        {
            LimitT = 20f;

            if(LimitT <= NowT)
            {
                gameoverPanel1.SetActive(true);
            }
        }
    }
}
