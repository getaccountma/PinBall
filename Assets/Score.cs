using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;//�X�R�A�p�ϐ�
    private GameObject scoreText;//�X�R�A��\������e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");//�V�[���̒���ScoreText�I�u�W�F�N�g���擾
        score = 0;//�X�R�A��������

    }

    //�Փˊ֐�
    private void OnCollisionEnter(Collision collision)
    {
        //�Փ˂����I�u�W�F�N�g�̃^�O�ɂ���ăX�R�A���_�����
        if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 10;

        }

        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }

        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 100;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //ScoreText�ɃX�R�A��\��
        this.scoreText.GetComponent<Text>().text = "Score:" + score;

    }
}
