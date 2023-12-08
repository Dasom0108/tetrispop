using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1animation : MonoBehaviour
{
    Stage stage;
    public Animator animator;
    void Start()
    {
        stage = GameObject.Find("1p Stage").GetComponent<Stage>();
   
    }

    // Update is called once per frame
    void Update()
    {
        if (stage.isdeleted)
        {
            animator.SetTrigger("isAttack");
            stage.isdeleted = false;

        }

        if(stage.gameoverPanel1.activeSelf)
        {
          animator.SetTrigger("isDie");
        }
    }
}
