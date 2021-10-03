using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("「隨時保持水分補充是很重要的，尤其是在運動過後」");
    }
}
