using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libruary : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
        //Debug.Log("�I���I�ڥH��o�������ѳ�");
        Gamemanager.instance.ShowText(" Click me! I��m full of the knowledge you desire.", 120, Color.blue, transform.position, Vector3.up * 1, 1f);
        


    }
}
