using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;//スコア用変数
    private GameObject scoreText;//スコアを表示するテキスト

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");//シーンの中のScoreTextオブジェクトを取得
        score = 0;//スコアを初期化

    }

    //衝突関数
    private void OnCollisionEnter(Collision collision)
    {
        //衝突したオブジェクトのタグによってスコア加点される
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
        //ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score:" + score;

    }
}
