using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideEffect : MonoBehaviour
{
    float time;

    // Update is called once per frame
    void Update()
    {
 
                if (time < 0.7f) //특정 위치에서 원점으로 이동
                {
                    this.transform.position = new Vector3(-(30 - 12 * time), 0, 0);
                }
                else if (time < 0.8f) // 튕기고
                {
                    this.transform.position = new Vector3(0.4f - time, 0, 0) * 4;
                }
                else if (time < 0.9f) //다시 제자리로
                {
                    this.transform.position = new Vector3(0.6f - time, 0, 0) * 4;
                }
                else if (time < 0.10f) //튕기고
                {
                    this.transform.position = new Vector3((time - 0.6f) / 2, 0, 0) * 4;
                }
                else if (time < 0.11f) //다시 제자리
                {
                    this.transform.position = new Vector3(0.05f - (time - 0.7f) / 2, 0, 0) * 4;
                }
                else
                {
                    this.transform.position = Vector3.zero;
                }

                time += Time.deltaTime;


            

        
    }

    public void resetAnim()
    {
        time = 0;
    }
}
