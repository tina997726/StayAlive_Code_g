using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("Need some help ?");
    }
}
