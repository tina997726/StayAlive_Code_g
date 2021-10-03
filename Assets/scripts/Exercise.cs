using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("「想成為下一個郭幸淳嗎？」");
    }
}
