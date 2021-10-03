using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talkbutton : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;
    public KeyCode key;

  

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggerenter");
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("triggerexit");
        Button.SetActive(false);
    }
    
    private void Update()
    {
        //KeyCode.R
        if (Input.GetKeyDown(key))
        {
            if(talkUI.activeSelf == false)
            {
                talkUI.SetActive(true);
            }
            else
            {
                talkUI.SetActive(false);
            }
        }

        /*
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R) )
        {
            talkUI.SetActive(true);
           
        }

        else if (talkUI.activeSelf==true && Input.GetKeyDown(KeyCode.R))
        {
            talkUI.SetActive(false);

        }*/
       
    }
}
