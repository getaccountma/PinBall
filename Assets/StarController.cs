using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    //��]���x
    private float rotspeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

        //��]�J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);//(0,360)�������Ƒ������̊ԁA�����_���ɉ�]�ʒu�����B�������͊܂܂�܂���B�O�`�R�T�X

    }

    // Update is called once per frame
    void Update()
    {

        //��]
        this.transform.Rotate(0, this.rotspeed, 0);

    }
}
