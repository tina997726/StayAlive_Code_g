using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashboard : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("�ݰ_�ӫܽ��������ާ@���F��A�ڦ����|�}�ӪŲ�ܡH");
    }
}
