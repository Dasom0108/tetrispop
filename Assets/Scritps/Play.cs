using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public void play()
    {
        var GM = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        GM.gamestart = true;
        Destroy(gameObject);
    }
}
