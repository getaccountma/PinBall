using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    //‰ñ“]‘¬“x
    private float rotspeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

        //‰ñ“]ŠJn‚·‚éŠp“x‚ğİ’è
        this.transform.Rotate(0, Random.Range(0, 360), 0);//(0,360)‘æˆêˆø”‚Æ‘æ“ñˆø”‚ÌŠÔAƒ‰ƒ“ƒ_ƒ€‚É‰ñ“]ˆÊ’u‚ğì‚éB‘æ“ñˆø”‚ÍŠÜ‚Ü‚ê‚Ü‚¹‚ñB‚O`‚R‚T‚X

    }

    // Update is called once per frame
    void Update()
    {

        //‰ñ“]
        this.transform.Rotate(0, this.rotspeed, 0);

    }
}
