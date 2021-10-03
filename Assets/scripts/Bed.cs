using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Ccollectable 
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        //Debug.Log("「休息是為了走更長遠的路（是為了不要走路ＱＱ」");
        Gamemanager.instance.ShowText("Rest is for a longer journey.",120,Color.blue,transform.position,Vector3.up*1,1f);
        //new color(放 rgb) 0-1
    }
}
