using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("¡uWelcome to the new adventure!¡v");
    }
}
