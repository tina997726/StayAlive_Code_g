using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
      //  Debug.Log("�৤�ۦ󥲯��۩O�]�~	");
        Gamemanager.instance.ShowText("If you could sit, then why would you stand?", 120, Color.blue, transform.position, Vector3.up * 0, 1f);

    }
}
