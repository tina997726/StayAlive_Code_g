using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Company : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("�u�ڬO�����H���������A��������D���i�H��ڡA���d�ˬd�]�O�ڭt�d�v");
    }
}
