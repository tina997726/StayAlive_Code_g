using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("「在長途宇宙旅行，稀少的肌肉量會是致命傷」");
    }
}
