using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : Ccollectable
{
    // public GameObject Button;
    //public GameObject talkUI;

   
    
    //Computer.ddays =  Gamedata.days;
    protected override void OnCollect()
    {
        base.OnCollect();// collected = true;
                         // Debug.Log("（顯示日期）我是一台電腦，但是我不能幹嘛，有事請找機器人唷＜３");
                         // Button.SetActive(true);
        Gamemanager.instance.ShowText(Gamemanager.instance.days+" I’m a computer, but there’s not much I can do for you." + "\r\n" + " Find robot 0913 for help <3. Wish you luck!", 120, Color.blue, transform.position, Vector3.up * 0, 1f) ;
    }
   /* private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            talkUI.SetActive(true);
            Button.SetActive(false);
        }
    }
   */
}
