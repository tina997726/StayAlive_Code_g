using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("�u�Q�����U�@�ӳ����E�ܡH�v");
    }
}
