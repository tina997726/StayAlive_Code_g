using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Ccollectable 
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        //Debug.Log("�u�𮧬O���F������������]�O���F���n�����ߢߡv");
        Gamemanager.instance.ShowText("Rest is for a longer journey.",120,Color.blue,transform.position,Vector3.up*1,1f);
        //new color(�� rgb) 0-1
    }
}
