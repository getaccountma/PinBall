using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //�ŏ��T�C�Y
    private float minimum = 1.0f;

    //�g��k���X�s�[�h
    private float magSpeed = 5.0f;

    //�g�嗦
    private float magnigication = 0.07f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�_���g��k��
        //this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication);
        this.transform.localScale = new Vector3(
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication,
            //Mathf.Sin�i���w�֘A��Mathf���g�p�j�BSin�֐����g�p����i�O�p�֐�_�p�x�jTime.time�̓Q�[�c���s�̌o�ߎ��ԁ��b�BSin�֐��͕K���|�P�`�P�̊Ԃɍs��������B
            this.transform.localScale.y,//y���͓�������Ȃ̂ŁA�ω����Ȃ�
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication);


    }


}
