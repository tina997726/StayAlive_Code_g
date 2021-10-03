using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coin : Ccollectable
{
    
    public Sprite emptycoin;
    public int coinamount = 10 ;
   
    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            Gamemanager.instance.dollars += 10;
            Gamemanager.instance.SaveState();
            Destroy(gameObject);
            //GetComponent<SpriteRenderer>().sprite = emptycoin;
            //Gamemanager.instance.ShowText("\r\n\r\n" + "You get " + coinamount + " dollar ! ", 90, Color.blue, transform.position, Vector3.up * 5, 1f);
        }
    }
   
}
