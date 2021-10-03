using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("找找看桌上有沒有需要的文件吧~");
    }
}
