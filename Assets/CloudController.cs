using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //最小サイズ
    private float minimum = 1.0f;

    //拡大縮小スピード
    private float magSpeed = 5.0f;

    //拡大率
    private float magnigication = 0.07f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小
        //this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication);
        this.transform.localScale = new Vector3(
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication,
            //Mathf.Sin（数学関連はMathfを使用）。Sin関数を使用する（三角関数_角度）Time.timeはゲーツ実行の経過時間＊秒。Sin関数は必ず－１～１の間に行き来する。
            this.transform.localScale.y,//y軸は同じ代入なので、変化しない
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnigication);


    }


}
