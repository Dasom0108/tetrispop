using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2animation : MonoBehaviour
{
    Stage2 stage2;
    public Animator animator;
    void Start()
    {
        stage2 = GameObject.Find("2p Stage").GetComponent<Stage2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stage2.isdeleted)
        {
            animator.SetTrigger("isAttack");
            stage2.isdeleted = false;

        }

        if(stage2.gameoverPanel.activeSelf)
        {
          animator.SetTrigger("isDie");
        }
    }
}
