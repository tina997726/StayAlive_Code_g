using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("�u�H�ɫO�������ɥR�O�ܭ��n���A�ר�O�b�B�ʹL��v");
    }
}
