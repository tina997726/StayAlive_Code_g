using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("���ݮ�W���S���ݭn�����a~");
    }
}
