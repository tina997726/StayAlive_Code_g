using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("當我亮了整個宇宙都暗了");
    }
}
