using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Company : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        Debug.Log("「我是機器人０９１３，有任何問題都可以找我，健康檢查也是我負責」");
    }
}
