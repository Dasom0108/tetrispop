using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideEffect : MonoBehaviour
{
    float time;

    // Update is called once per frame
    void Update()
    {
 
                if (time < 0.7f) //Ư�� ��ġ���� �������� �̵�
                {
                    this.transform.position = new Vector3(-(30 - 12 * time), 0, 0);
                }
                else if (time < 0.8f) // ƨ���
                {
                    this.transform.position = new Vector3(0.4f - time, 0, 0) * 4;
                }
                else if (time < 0.9f) //�ٽ� ���ڸ���
                {
                    this.transform.position = new Vector3(0.6f - time, 0, 0) * 4;
                }
                else if (time < 0.10f) //ƨ���
                {
                    this.transform.position = new Vector3((time - 0.6f) / 2, 0, 0) * 4;
                }
                else if (time < 0.11f) //�ٽ� ���ڸ�
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
