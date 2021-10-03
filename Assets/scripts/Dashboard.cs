using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashboard : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("看起來很複雜很難操作的東西，我有機會開太空船嗎？");
    }
}
