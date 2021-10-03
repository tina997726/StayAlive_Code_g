using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_0 : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        //Debug.Log("「需要買東西嗎？	沒有錢解決不了的問題！」");
        Gamemanager.instance.ShowText("robot", 120, Color.blue, transform.position, Vector3.up * 1, 1f);
        //Gamemanager.instance.ShowText("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" + "\n\r\n\r\n\r\n\r\n\r\n" + "It's absolutely not a problem if money could solve it. But the real problem is not enough money.", 120, Color.blue, transform.position, Vector3.up * 1, 1f);

    }
}
