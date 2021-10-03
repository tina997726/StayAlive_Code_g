using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : Ccollectable
{    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("I EAT MONEY MONEY $$$");
    }
}
