using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Ccollectable
{
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
      //  Debug.Log("能坐著何必站著呢（誤	");
        Gamemanager.instance.ShowText("If you could sit, then why would you stand?", 120, Color.blue, transform.position, Vector3.up * 0, 1f);

    }
}
