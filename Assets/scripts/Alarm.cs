using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("��ګG�F��Ӧt�z���t�F");
    }
}
