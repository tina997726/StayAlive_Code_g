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
                         // Debug.Log("�]��ܤ���^�ڬO�@�x�q���A���O�ڤ���F���A���ƽЧ�����H��բ�");
                         // Button.SetActive(true);
        Gamemanager.instance.ShowText(Gamemanager.instance.days+" I��m a computer, but there��s not much I can do for you." + "\r\n" + " Find robot 0913 for help <3. Wish you luck!", 120, Color.blue, transform.position, Vector3.up * 0, 1f) ;
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
