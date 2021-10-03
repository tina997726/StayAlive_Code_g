using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ccollectable : ccollidable
{

    //logic
    protected bool collected;
    protected override void Oncollide(Collider2D coll)
    {
        if (coll.name == "player_0")
        {
            OnCollect();
        }
    }
    protected virtual void OnCollect()
    {
        collected = true;
    }
}
