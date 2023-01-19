using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    //回転速度
    private float rotspeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

        //回転開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);//(0,360)第一引数と第二引数の間、ランダムに回転位置を作る。第二引数は含まれません。０〜３５９

    }

    // Update is called once per frame
    void Update()
    {

        //回転
        this.transform.Rotate(0, this.rotspeed, 0);

    }
}
